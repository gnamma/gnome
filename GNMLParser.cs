using System;
using System.IO;

namespace Gnome {
    public class GNMLParser {
        private TextReader stream;

        public void FromStream(TextReader reader) {
            stream = reader;
        }

        public void FromString(string gnml) {
            FromStream(new StringReader(gnml));
        }

        public void Parse() {
            if (stream == null) {
                throw new Exception("No text stream found");
            }

            String line;
            while ((line = stream.ReadLine()) != null) {
                Console.Write(line);
            }
        }
    }
}
