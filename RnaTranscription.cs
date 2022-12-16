using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string rna = "";

        if( String.IsNullOrEmpty( dna ) )
            return "";

        for (int cnt = 0; cnt < dna.Length; cnt++)
        {
            switch(dna[cnt])
            {
                case 'G' : rna = rna + 'C'; break;
                case 'A' : rna = rna + 'U'; break;
                case 'T' : rna = rna + 'A'; break;
                case 'C' : rna = rna + 'G'; break;
            }
        }

            return rna;
    }
}