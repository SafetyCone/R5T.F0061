using System;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

using R5T.T0132;
using R5T.T0146;


namespace R5T.F0061
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker
	{
		public void WriteLinesAndOpenInNotepadPlusPlus(
			IEnumerable<string> lines,
			string resultFilePath)
        {
			Instances.FileOperator.Write_Lines_Synchronous(
				resultFilePath,
				lines);

			Instances.NotepadPlusPlusOperator.Open(
				resultFilePath);
		}

		public void WriteLinesAndOpenInNotepadPlusPlus(
			IEnumerable<string> lines)
		{
			var resultFilePath = Instances.FilePaths.OutputTextFilePath;

			this.WriteLinesAndOpenInNotepadPlusPlus(
				lines,
				resultFilePath);
		}

		public void WriteResultAndOpenInNotepadPlusPlus(
			Result result,
			string resultFilePath,
			ILogger logger)
		{
			logger.InLogContext(
				$"Writing result output...\n\t{resultFilePath}",
				$"Wrote result output.\n\t{resultFilePath}",
				() => Instances.ResultSerializer.Serialize(resultFilePath, result));

			logger.InLogContext(
				$"Opening result output in Notepad++...\n\t{resultFilePath}",
				$"Opened result output in Notepad++:\n\t{resultFilePath}",
				() => Instances.NotepadPlusPlusOperator.Open(resultFilePath));
		}
	}
}