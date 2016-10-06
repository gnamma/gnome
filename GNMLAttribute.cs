using System;

namespace Gnome {
    public class GNMLAttribute {
        private string name;
        private string val;

        public GNMLAttribute(string name, string val) {
            this.name = name;
            this.val = val;
        }

        public string Name {
            get {
                return name;
            }
        }

        public string Value {
            get {
                return val;
            }
        }
    }
}
