﻿using System;

namespace console {
	public static class ConsoleQuestion {
		// ReSharper disable once InconsistentNaming
		public static bool AskYN(string question) {
			Console.Write(question + " (Y/N)? ");

			ConsoleKeyInfo key;
			do {
				key = Console.ReadKey();
			} while (key.Key != ConsoleKey.Y && key.Key != ConsoleKey.N);
			Console.WriteLine();
			return key.Key == ConsoleKey.Y;
		}
	}
}
