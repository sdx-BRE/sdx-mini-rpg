using Godot;
using System;
using System.Linq;
using System.Reflection;

namespace SDX.AbilitySystem.Tests
{
	[Tool]
	public partial class RunAllTests : EditorScript
	{
		public override void _Run()
		{
			GD.Print("\n=============================================");
			GD.Print("        RUNNING ALL ABILITY SYSTEM TESTS     ");
			GD.Print("=============================================\n");

			var testSuiteType = typeof(EditorTestSuite);
			var suites = testSuiteType.Assembly.GetTypes()
				.Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(testSuiteType));

			int totalPassed = 0;
			int totalFailed = 0;
			int totalSuites = 0;

			foreach (var suiteType in suites)
			{
				var suite = (EditorTestSuite)Activator.CreateInstance(suiteType);
				suite._Run(); // Run the suite

				totalPassed += suite.PassedCount;
				totalFailed += suite.FailedCount;
				totalSuites++;
			}

			GD.Print("\n=============================================");
			GD.Print("                FINAL RESULTS                ");
			GD.Print("=============================================");
			GD.Print($"Suites Executed: {totalSuites}");
			if (totalFailed == 0)
			{
				GD.PrintRich($"[color=green]ALL {totalPassed} TESTS ACROSS {totalSuites} SUITES PASSED![/color]");
			}
			else
			{
				GD.PrintRich($"[color=red]FAILED: {totalFailed} | PASSED: {totalPassed}[/color]");
			}
			GD.Print("=============================================\n");
		}
	}
}
