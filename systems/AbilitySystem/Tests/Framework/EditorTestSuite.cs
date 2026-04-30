using Godot;
using System;
using System.Diagnostics;

namespace SDX.AbilitySystem.Tests
{
	public abstract partial class EditorTestSuite : EditorScript
	{
		public int PassedCount { get; private set; } = 0;
		public int FailedCount { get; private set; } = 0;

		public override void _Run()
		{
			var suiteName = GetType().Name;
			GD.Print($"\n========== RUNNING SUITE: {suiteName} ==========");
			
			PassedCount = 0;
			FailedCount = 0;
			
			RunTests();
			
			GD.Print($"========== SUITE {suiteName} COMPLETED ==========");
			if (FailedCount == 0)
			{
				GD.PrintRich($"[color=green]ALL {PassedCount} TESTS PASSED[/color]");
			}
			else
			{
				GD.PrintRich($"[color=red]FAILED: {FailedCount} | PASSED: {PassedCount}[/color]");
			}
		}

		protected abstract void RunTests();

		protected void AssertTrue(bool condition, string message = "")
		{
			if (condition)
			{
				PassedCount++;
			}
			else
			{
				FailedCount++;
				var trace = new StackTrace(1, true).GetFrame(0);
				GD.PrintErr($"[ASSERT FAILED] {message} (Line {trace?.GetFileLineNumber()})");
			}
		}

		protected void AssertFalse(bool condition, string message = "")
		{
			AssertTrue(!condition, message);
		}

		protected void AssertEqual<T>(T expected, T actual, string message = "")
		{
			if (object.Equals(expected, actual))
			{
				PassedCount++;
			}
			else
			{
				FailedCount++;
				var trace = new StackTrace(1, true).GetFrame(0);
				GD.PrintErr($"[ASSERT EQUAL FAILED] Expected '{expected}', got '{actual}'. {message} (Line {trace?.GetFileLineNumber()})");
			}
		}
	}
}
