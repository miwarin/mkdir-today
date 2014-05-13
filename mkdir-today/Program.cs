using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mkdir_today
{
    class Program
    {
        static private String Today()
        {
            DateTime d = DateTime.Today;
            String today = d.ToString("yyyy/MM/dd");
            return today;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("コマンドライン引数はありません。");
                return;
            }

            String basedir = Path.GetDirectoryName(args[0]);
            if (Directory.Exists(basedir) == false)
            {
                Console.WriteLine("ディレクトリを指定してね");
                return;
            }

            String today = Today();
            String path = Path.Combine(basedir, today);
            Console.WriteLine("create {0}", path);
            Directory.CreateDirectory(path);
        }
    }
}
