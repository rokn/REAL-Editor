using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using REALCore;

namespace REALProjectManagement
{
	public class RealProject : IProject
	{
		public RealProject(string name)
		{
			Name = name;
			Files = new List<FileInfo>();
			Scene = new EntityWorld();
			Saved = false;
		}

		public string ProjectPath { get; private set; }

		public string Name { get; private set; }

		public List<FileInfo> Files { get; }

		public EntityWorld Scene { get; }

		public bool Saved { get; private set; }

		public bool Save()
		{
			if (ProjectPath == null)
			{
				return false;
			}

			var project = new XDocument();
			var root = new XElement("RealProject");
			project.Add(root);
			root.Add(new XElement("ProjectName", Name));

			foreach(var fileInfo in Files)
			{
				root.Add(new XElement("ImportedFile", fileInfo.ToString()));
			}

			using(var stream = new FileStream(ProjectPath, FileMode.Create))
			{
				project.Save(stream);
			}

			Saved = true;
			return true;
		}

		public bool SaveAs(string newFilename)
		{
			if (newFilename == null)
			{
				throw new ArgumentNullException();
			}

			Directory.CreateDirectory(Path.GetDirectoryName(newFilename));
			ProjectPath = newFilename;
			
			return Save();
		}

		public bool Load(string filename)
		{
			if(filename == null || !File.Exists(filename))
			{
				throw new ArgumentNullException();
			}

			ProjectPath = filename;
			XDocument project;

			using (var stream = new FileStream(filename, FileMode.Open))
			{
				project = XDocument.Load(stream);
			}

			var root = project.Element("RealProject");
			var projectName = root?.Element("ProjectName");
			Name = projectName?.Value;

			foreach (var xElement in root.Elements("ImportedFile"))
			{
				Files.Add(new FileInfo(xElement.Value));
			}

			Saved = true;

			return true;
		}

		public void ImportFile(string filepath, string subFolder = "")
		{
			if(filepath == null || !File.Exists(filepath))
				throw new FileNotFoundException();

			var dirInfo = Directory.CreateDirectory(Path.Combine(Path.GetDirectoryName(ProjectPath), subFolder));

			File.Copy(
				sourceFileName: filepath, 
				destFileName: Path.Combine(dirInfo.FullName, Path.GetFileName(filepath)),
				overwrite: true);

			var newFile = new FileInfo(Path.Combine(subFolder, Path.GetFileName(filepath)));

			if(Files.All(file => file.ToString() != newFile.ToString()))
				Files.Add(newFile);

			Saved = false;
		}

		public void RemoveFile(FileInfo file)
		{
			throw new System.NotImplementedException();
			Saved = false;
		}

		public bool ContainsFile(FileInfo fileInfo)
		{
			return Files.Any(info => 
					ProjectPath != null 
					&& (fileInfo.FullName == GetFilePath(info) 
						|| fileInfo.ToString() == info.ToString()));
		}

		public void OpenFile(FileInfo info)
		{
			if (ContainsFile(info))
			{
				System.Diagnostics.Process.Start(GetFilePath(info));
			}
			else
			{
				throw new FileNotFoundException();
			}
		}

		private string GetFilePath(FileInfo info)
		{
			return Path.Combine(Path.GetDirectoryName(ProjectPath), info.ToString());
		}
	}
}
