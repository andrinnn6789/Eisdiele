using Eisdiele.Decoratees;
using Eisdiele.Decorater;

namespace Eisdiele;

public class Program
{
    public static void Main(string[] args)
    {
        Eis waffel = new Waffel();
        waffel = new Sahne(waffel);
        waffel = new Schokokugel(waffel);
        waffel = new Vanillekugel(waffel);
        waffel = new Sahne(waffel);

        Eis becher = new Becher();
        becher = new Schokokugel(becher);
        becher = new Sahne(becher);
        becher = new Sahne(becher);
        becher = new Vanillekugel(becher);

        Console.WriteLine(becher.GetBeschreibung() + " " + becher.BerechnePreis() + " $");
        Console.WriteLine(waffel.GetBeschreibung() + " " + waffel.BerechnePreis() + " $");

    }
}