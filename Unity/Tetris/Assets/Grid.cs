using UnityEngine;
using System.Collections;

/**
 * Represents the grid on which the game is played
 */
public class Grid : MonoBehaviour {

	public static int width = 10;
	public static int height = 20;
	public static Transform[,] grid = new Transform[width, height];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * Rounds and returns the given 2D vector.
	 */
	public static Vector2 roundVec2(Vector2 v) {
		return new Vector2(Mathf.Round(v.x),
		                   Mathf.Round(v.y));
	}

	/**
	 * Returns true if the given position is within the border of the grid, false otherwise.
	 */
	public static bool instideBorder(Vector2 pos) {
		// pos is inside grid border if its x component is greater than 0 and less than the grid width
		// "pos.y < h" is not checked since groups don't move upwards
		return ((int)pos.x >= 0 &&
				(int)pos.x < width &&
				(int)pos.y >= 0);
	}

	/**
	 * Deletes all blocks in the given row.
	 */
	public static void deleteRow(int y) {
		// Loop through and delete every block in the given row
		for (int x = 0; x < width; x++) {
			Destroy(grid[x, y].gameObject);
			grid[x, y] = null;
		}
	}

	/**
	 * Moves all blocks in the given row down one unit.
	 */
	public static void decreaseRow(int y) {
		for (int x = 0; x < width; x++) {
			if (grid[x, y] != null) {
				grid[x, y-1] = grid[x, y]; // Copy block to next row down
				grid[x, y] = null; // Nullify original block

				// Update the block's position
				grid[x, y-1].position += new Vector3(0, -1, 0);
			}
		}
	}

	/**
	 * Move all rows above the given row down one unit.
	 */
	public static void decreaseRowsAbove(int y) {
		for (int i = y + 1; i < height; i++)
			decreaseRow (i);
	}

	/**
	 * Returns true if the given row is full.
	 */
	public static bool isRowFull(int y) {
		for (int x = 0; x < width; x++) {
			if (grid[x, y] == null)
				return false;
		}
		return true;
	}

	/**
	 * Deletes all full rows and moves other rows accordingly.
	 */
	public static void deleteFullRows() {
		for (int y = 0; y < height; y++) {
			if (isRowFull(y)) {
				// Delete current row and move rows above it down
				deleteRow(y);
				decreaseRowsAbove(y);

                /* Since this row has been deleted, we decrement y to 
                 * ensure the next row checked is the newly moved row. 
                 */
				y--;
			}
		}
	}
}
