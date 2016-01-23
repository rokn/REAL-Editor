using System.Collections.Generic;
using System.IO;
using REALCore;

namespace REALProjectManagement
{
	public class Project : IProject
	{
		public Project()
		{
			Files = new List<FileInfo>();
			Scene = new EntityWorld();
		}

		public string FilePath { get; private set; }

		public List<FileInfo> Files { get; }

		public EntityWorld Scene { get; private set; }

		public bool Save()
		{
			if (FilePath == null || !File.Exists(FilePath))
			{
				return false;
			}

			return true;
		}

		public bool SaveAs(string newFilename)
		{
			throw new System.NotImplementedException();
		}

		public bool Load(string filename)
		{
			FilePath = filename;
			return true;
		}

		public void ImportFile(string filepath)
		{
			throw new System.NotImplementedException();
		}

		public void RemoveFile(FileInfo file)
		{
			throw new System.NotImplementedException();
		}
	}
}
