using Gnome;

class Test {
    static void Main() {
        var parser = new GNMLParser();
        parser.FromString("<room></room");

        parser.Parse();
    }
}
