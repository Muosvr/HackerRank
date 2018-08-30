using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the maximumPeople function below.
    static long maximumPeople(long[] p, long[] x, long[] y, long[] r) {
        // Return the maximum number of people that will be in a sunny town after removing exactly one cloud.

        int cloudyLoc = new List<int>();

        //cycle through each cloud
            for (j = 0; j < cloudLocArrOri; j++)
            {
                //remove the cloud being indexed
                cloudLocArr.RemoveAt(0);
                cloudRArr.RemoveAt(0);

                //calculate the population still being covered
                //cycle through remaining cloud using the locaiton function to produce an array of location being covered
                for(i=0; i< cloudLocArr.Length; i++)
                {
                    //Loop that returns the location being overed by cloud
                    int cloudLoc = cloudLocArr[i];
                    int cloudR = cloudSizArr[i];

                    for (var i = cloudLoc-cloudR; i < cloudLoc + cloudR; i++)
                    {
                        if(!cloudyLoc.Contains(i))
                            cloudyLoc.Add(i);
                    }

                }

                //loop through all towns location and calculate population still being covered
            }



        //return the cloud which if removed will uncover highest population
    }



    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        long[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt64(pTemp))
        ;

        long[] x = Array.ConvertAll(Console.ReadLine().Split(' '), xTemp => Convert.ToInt64(xTemp))
        ;
        int m = Convert.ToInt32(Console.ReadLine());

        long[] y = Array.ConvertAll(Console.ReadLine().Split(' '), yTemp => Convert.ToInt64(yTemp))
        ;

        long[] r = Array.ConvertAll(Console.ReadLine().Split(' '), rTemp => Convert.ToInt64(rTemp))
        ;
        long result = maximumPeople(p, x, y, r);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
