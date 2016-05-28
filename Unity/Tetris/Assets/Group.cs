using UnityEngine;
using System.Collections;

/**
 * Represents a single tetromino.
 */
public class Group : MonoBehaviour {

    // Time since the last automatic movement down
    private float lastFall = 0;

    private int count = 0;

    // Use this for initialization
    public void Start() {
        // If the default position is not valid, the grid is full (Game Over)
        if (!isValidGridPos()) {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
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
        // Move the tetromino downwards (using down key and automatically each time tick)
        else if (Input.GetKeyDown(KeyCode.DownArrow) ||
                 Input.GetKey(KeyCode.DownArrow) ||
                 Time.time - lastFall >= 0.25) {
            if (Input.GetKey(KeyCode.DownArrow)) {
                count++;
                if (count == 3) {
                    count = 0;
                    moveDown();
                }
            }
            else {
                moveDown();
            }

            // Update the time tracker
            lastFall = Time.time;
        }
    }

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

    private void rotate() {
        // Do not rotate the box-shaped tetromino
        if (this.name.Contains("GroupO")) {
            return;
        }

        // Modify the position
        transform.Rotate(0, 0, -90);

        // If the new position is valid, update the grid
        if (isValidGridPos()) {
            updateGrid();
            // Otherwise, revert the change in position
        }
        else {
            transform.Rotate(0, 0, 90);
        }
    }

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

            /* If the new position is invalid, the tetromino has hit the bottom and 
             * needs to stop moving.
             */

            // Clear any filled rows
            Grid.deleteFullRows();

            // Spawn next tetromino
            FindObjectOfType<Spawner>().spawnNext();

            // Disable this script
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
