using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string filename;

        public FileSaver(string filename)
        {
            this.filename = filename;
        }

        public void Update(AbstractStringSubject sub)
        {
            string info = sub.Item;

            File.AppendAllText(filename, info + "\n");
        }
    }
}