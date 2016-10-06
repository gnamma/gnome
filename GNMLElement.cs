using System;

namespace Gnome {
    public class GNMLElement {
        private string name;
        private GNMLElement parent;

        private GNMLDirective[] directives;
        private GNMLAttribute[] attributes;

        public string Name {
            get {
                return name;
            }
        }

        public GNMLElement Parent {
            get {
                return parent;
            }
        }
    }
}
