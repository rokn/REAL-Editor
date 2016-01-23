using System.Collections.Generic;
using System.IO;
using REALCore;

namespace REALProjectManagement
{
	public interface IProject
	{
		string FilePath { get; }
		List<FileInfo> Files { get; }
		EntityWorld Scene { get; }

		bool Save();
		bool SaveAs(string newFilename);
		bool Load(string filename);
		void ImportFile(string filepath);
		void RemoveFile(FileInfo file);
	}
}
