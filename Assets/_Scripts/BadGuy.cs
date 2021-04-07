public class BadGuy{

    public string name;
    public int strength;

    public BadGuy(string name, int strength) {
        this.name = name;
        this.strength = strength;
    }

    public override string ToString() {
        return string.Format("Bad Guy ({0}, {1})", this.name, this.strength);
    }
}
