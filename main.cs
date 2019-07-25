using System.Collections.Generic;
class program
{
  public static List < double >ListTerms = new List < double >();
  public static string[] inputs;
  public static double[] compound;
  static void Main ()
  {
    bool bol = true;
      Console.WriteLine
      ("This does your combusion for you so you don't have to!");
      Console.WriteLine
      ("How many carbons, oxygens, and hydrogens are in your organic compound? Enter your integers seperated by a space");
      inputs = Console.ReadLine ().Split (' ');
      foreach (string input in inputs)
    {
      double d;
      if (!double.TryParse (input, out d))
	{
	  Console.WriteLine (input);
	  bol = true;
	}
      ListTerms.Add (d);
    }
    compound = ListTerms.ToArray ();
    double startc = compound[0];
    double starto = compound[1];
    double starth = compound[2];
    double codos = startc;
    double oxydos = codos;
    double water = 0;
    double compoundmult = 1;
    for (int i = 0; i < starth; i++)
      {
	if (i % 2 == 0)
	  {
	    water++;
	    if (starto > 0)
	      {
		starto = starto - 1;
	      }
	    else
	      {
		oxydos = oxydos + 0.5;
	      }
	  }
      }
    if (!(oxydos % 1 == 0))
      {
	compoundmult = compoundmult * 2;
	codos = codos * 2;
	oxydos = oxydos * 2;
	water = water * 2;
      }
    while (starto > 0)
      {
	while (starto > 0)
	  {
	    starto = starto - 1;
	    oxydos = oxydos - 0.5;
	  }
	if (!(oxydos % 1 == 0))
	  {
	    compoundmult = compoundmult * 2;
	    codos = codos * 2;
	    oxydos = oxydos * 2;
	    water = water * 2;
	    starto = starto * 2;
	  }

      }
    string chemicalform =
      string.Format ("C{0}H{1}O{2}", compound[0], compound[2], compound[1]);
    string output =
      string.Format ("{0}{1} + {2}O2 --> {3}CO2 + {4}H2O", compoundmult,
		     chemicalform, oxydos, codos, water);
    Console.WriteLine (output);
  }
}

