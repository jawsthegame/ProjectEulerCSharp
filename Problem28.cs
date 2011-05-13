using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerTom {
	public class Problem28 {
		enum Direction { Up, Down, Left, Right }

		public static void Run() {

			const int rows = 5;
			var nums = new int[5][];

			var currentX = rows / 2;
			var currentY = currentX;

			var direction = Direction.Right;

			var count = 1;
			var changeDirection = false;
			var movementCount = 1;

			var numAtMovement = 0;

			for (var i = 0; i < rows; i++) {
				nums[i] = new int[rows];
			}

			while (currentX != rows && currentY != 0) {
				nums[currentY][currentX] = count;
				changeDirection = count == 1 || (count - numAtMovement) % movementCount == 0;
				movementCount++;

				switch (direction) {
					case Direction.Right:
						currentX += 1;
						if (changeDirection) {
							direction = Direction.Down;
						}
						break;
					case Direction.Down:
						currentY += 1;
						if (changeDirection) {
							direction = Direction.Left;
						}
						break;
					case Direction.Left:
						currentX -= 1;
						if (changeDirection) {
							direction = Direction.Up;
						}
						break;
					case Direction.Up:
						currentY -= 1;
						if (changeDirection) {
							direction = Direction.Right;
						}
						break;
				}

				if (changeDirection) {
					movementCount = 1;
					numAtMovement = count;
				}

				count++;
			}

			foreach (var row in nums) {
				Console.WriteLine(String.Join(" ", row));
			}

			Console.ReadKey();
		}
	}
}
