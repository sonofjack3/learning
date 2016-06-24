using UnityEngine;
using System.Collections;

/**
 * Represents the behavior of a single tetromino.
 */
public class GroupBehavior : MonoBehaviour {

    private const float QuarterSecond = 0.25f;
    
    // When the down arrow is held, wait this many frames before moving the tetromino down
    private const int FramesWaitBeforeDown = 3;
    
    // Time since the last automatic movement down
    private float lastFall = 0;

    // Tracks the number of frames the down arrow has been held for
    private int framesDownHeld = 0;

    /**
     * Initialization.
     */
    public void Start() {
        // If the default position is not valid, the grid is full (Game Over)
        if (!isValidGridPos()) {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }

    /**
     * Called once per frame.
     */
    public void Update() {
        // Move tetromino left
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            moveLeft();
        }
        // Move tetromino right
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            moveRight();
        }
        // Rotate the tetromino
        else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rotate();
        }
        /* Move the tetromino downwards when:
         *  1. The down key is pressed, or
         *  2. A quarter of a second has passed since the last time the tetromino moved down.
         */
        else if (Input.GetKeyDown(KeyCode.DownArrow) ||
                 Time.time - lastFall >= QuarterSecond) {
            moveDown();

            // Update the time tracker
            lastFall = Time.time;
        }
        // Move the tetromino downwards when holding the down key
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            framesDownHeld++;

            /* While holding the down arrow, only move down once
             * FramesWaitBeforeDown number of frames have passed.
             */
            if (framesDownHeld == FramesWaitBeforeDown)
            {
                // Reset counter
                framesDownHeld = 0;
                moveDown();
            }

            // Update the time tracker
            lastFall = Time.time;
        }
    }

    /**
     * Move the tetromino left one unit.
     */
    private void moveLeft() {
        // Modify the position
        transform.position += new Vector3(-1, 0, 0);

        // If the new position is valid, update the grid
        if (isValidGridPos()) {
            updateGrid();
        }
        // Otherwise, revert the change in position
        else {
            transform.position += new Vector3(1, 0, 0);
        }
    }

    /**
     * Move the tetromino right one unit.
     */
    private void moveRight() {
        // Modify the position
        transform.position += new Vector3(1, 0, 0);

        // If the new position is valid, update the grid
        if (isValidGridPos()) {
            updateGrid();
        }
        // Otherwise, revert the change in position
        else {
            transform.position += new Vector3(-1, 0, 0);
        }
    }

    /**
     * Rotate the tetromino.
     */
    private void rotate() {
        // Do not rotate the box-shaped tetromino (Group O)
        if (this.name.Contains(Constants.GroupOName)) {
            return;
        }

        // Modify the position
        transform.Rotate(0, 0, -90);

        // If the new position is valid, update the grid
        if (isValidGridPos()) {
            updateGrid();
        }
        // Otherwise, revert the change in position
        else
        {
            transform.Rotate(0, 0, 90);
        }
    }

    /**
     * Move the tetromino down one unit.
     */
    private void moveDown() {
        // Modify the position
        transform.position += new Vector3(0, -1, 0);

        // If the new position is valid, update the grid
        if (isValidGridPos()) {
            updateGrid();
        }
        // Otherwise, revert the change in position
        else {
            transform.position += new Vector3(0, 1, 0);

            // Clear any filled rows
            Grid.deleteFullRows();

            // Spawn next tetromino
            FindObjectOfType<Spawner>().spawnNext();

            /* If the new position is invalid, the tetromino has hit the bottom and 
             * needs to stop moving.
             */
            enabled = false;
        }
    }

    /**
     * Returns true if this tetromino is at a valid grid position, false otherwise.
     */
    private bool isValidGridPos() {
        // Look at each block inside the tetromino
        foreach (Transform block in transform)
        {
            Vector2 v = Grid.roundVec2(block.position);

            // If the current block is not inside the grid's borders, return false
            if (!Grid.insideBorder(v))
                return false;

            /* If there is an intersection between the current block and another
             * block in a different group, return false.
             */
            if (Grid.grid[(int)v.x, (int)v.y] != null &&
                Grid.grid[(int)v.x, (int)v.y].parent != transform)
                return false;
        }
        return true;
    }

    /**
     * Updates the Grid when this tetromino moves
     */
    private void updateGrid() {
        // Remove old blocks from the grid
        for (int y = 0; y < Grid.height; y++) {
            for (int x = 0; x < Grid.width; x++) {
                if ((Grid.grid[x, y] != null)  &&
                    (Grid.grid[x, y].parent == transform)) {
                        Grid.grid[x, y] = null;
                }
            }
        }

        // Add new blocks with new positions to the grid
        foreach (Transform block in transform) {
            Vector2 v = Grid.roundVec2(block.position);
            Grid.grid[(int)v.x, (int)v.y] = block;
        }
    }
}
