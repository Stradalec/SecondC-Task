using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondC_Task {

  internal class Program {
    public class Singleton {
      public static Singleton Instance {
        get {
          if (instance == null) instance = new Singleton();
          return instance;
        }
      }
      public void ShowTxt() {
        TextFile file = new TextFile();
        file.ShowInfo();
      }
      public void ShowDoc() {
        DocFile file = new DocFile();
        file.ShowInfo();
      }
      public void ShowPdf() {
        PDFFile file = new PDFFile();
        file.ShowInfo();
      }
      public void ShowXlsx() {
        XlsxFile file = new XlsxFile();
        file.ShowInfo();
      }
      public void ShowHTML() {
        HTMLFile file = new HTMLFile();
        file.ShowInfo();
      }
      private Singleton() {

      }
      private static Singleton instance;
    }
    public abstract class File {
      protected static string fileExtension = "null";
      protected string fileName = "Iam" + fileExtension + "file." + fileExtension;
      protected string authorOfFile = "Some random guy";
      protected string[] keywordsInFile = { "suffering", "loneliness", "shame" };
      protected string fileTheme = "Life";
      protected string filePath = "C:/Directory/" + fileExtension + "file." + fileExtension;



      public virtual void ShowInfo() {

      }
    }
    public class TextFile : File {
      public override void ShowInfo() {
        fileExtension = "txt";
        filePath = "C:/Directory/" + fileExtension + "file." + fileExtension;
        fileName = "Iam" + fileExtension + "file." + fileExtension;
        Console.WriteLine("Name of file: " + fileName);
        Console.WriteLine("Author of file: " + authorOfFile);
        for (int outputIndex = 0; outputIndex < keywordsInFile.Length; outputIndex++) {
          Console.WriteLine("Keywords in file number " + (outputIndex + 1) + " : " + keywordsInFile[outputIndex]);
        }
        Console.WriteLine("Theme of file: " + fileTheme);
        Console.WriteLine("Path of file: " + filePath);
        Console.WriteLine("Extension of file: " + fileExtension);
      }
    }

    public class DocFile : File {
      public override void ShowInfo() {
        fileExtension = "docx";
        filePath = "C:/Directory/" + fileExtension + "file." + fileExtension;
        fileName = "Iam" + fileExtension + "file." + fileExtension;
        Console.WriteLine("Name of file: " + fileName);
        Console.WriteLine("Author of file: " + authorOfFile);
        for (int outputIndex = 0; outputIndex < keywordsInFile.Length; ++outputIndex) {
          Console.WriteLine("Keywords in file number " + (outputIndex + 1) + " : " + keywordsInFile[outputIndex]);
        }
        Console.WriteLine("Theme of file: " + fileTheme);
        Console.WriteLine("Path of file: " + filePath);
        Console.WriteLine("Extension of file: " + fileExtension);
      }
    }

    public class PDFFile : File {
      public override void ShowInfo() {
        fileExtension = "pdf";
        filePath = "C:/Directory/" + fileExtension + "file." + fileExtension;
        fileName = "Iam" + fileExtension + "file." + fileExtension;
        Console.WriteLine("Name of file: " + fileName);
        Console.WriteLine("Author of file: " + authorOfFile);
        for (int outputIndex = 0; outputIndex < keywordsInFile.Length; ++outputIndex) {
          Console.WriteLine("Keywords in file number " + (outputIndex + 1) + " : " + keywordsInFile[outputIndex]);
        }
        Console.WriteLine("Theme of file: " + fileTheme);
        Console.WriteLine("Path of file: " + filePath);
        Console.WriteLine("Extension of file: " + fileExtension);
      }
    }
    public class XlsxFile : File {
      public override void ShowInfo() {
        fileExtension = "xlsx";
        filePath = "C:/Directory/" + fileExtension + "file." + fileExtension;
        fileName = "Iam" + fileExtension + "file." + fileExtension;
        Console.WriteLine("Name of file: " + fileName);
        Console.WriteLine("Author of file: " + authorOfFile);
        for (int outputIndex = 0; outputIndex < keywordsInFile.Length; ++outputIndex) {
          Console.WriteLine("Keywords in file number " + (outputIndex + 1) + " : " + keywordsInFile[outputIndex]);
        }
        Console.WriteLine("Theme of file: " + fileTheme);
        Console.WriteLine("Path of file: " + filePath);
        Console.WriteLine("Extension of file: " + fileExtension);
      }
    }
    public class HTMLFile : File {
      public override void ShowInfo() {
        fileExtension = "html";
        filePath = "C:/Directory/" + fileExtension + "file." + fileExtension;
        fileName = "Iam" + fileExtension + "file." + fileExtension;
        Console.WriteLine("Name of file: " + fileName);
        Console.WriteLine("Author of file: " + authorOfFile);
        for (int outputIndex = 0; outputIndex < keywordsInFile.Length; ++outputIndex) {
          Console.WriteLine("Keywords in file number " + (outputIndex + 1) + " : " + keywordsInFile[outputIndex]);
        }
        Console.WriteLine("Theme of file: " + fileTheme);
        Console.WriteLine("Path of file: " + filePath);
        Console.WriteLine("Extension of file: " + fileExtension);
      }
    }
    static void Main(string[] args) {
      char select = ' ';
      Console.WriteLine("Select your file type: t = txt, d = docx, p = PDF, x = xlsx, h = HTML");
      select = Convert.ToChar(Console.ReadLine());
      switch (select) {
        case 't':
          Singleton.Instance.ShowTxt();
          break;
        case 'd':
          Singleton.Instance.ShowDoc();
          break;
        case 'p':
          Singleton.Instance.ShowPdf();
          break;
        case 'x':
          Singleton.Instance.ShowXlsx();
          break;
        case 'h':
          Singleton.Instance.ShowHTML();
          break;
        default:
          Console.WriteLine("Wrong file type");
          break;
      }
      Console.ReadKey();
    }
  }
}
