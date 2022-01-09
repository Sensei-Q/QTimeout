// QTimeout v1.0 (c) 2022 Sensei (aka 'Q')
// Putting a batch script to sleep without an open console (QStart).
//
// Usage:
// QTimeout seconds
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc QTimeout.cs
//
// Examples:
// QTimeout 1
// QTimeout 5.5

using System;
using System.Globalization;
using System.Threading;

public class QTimeout {
   public static void Help() {
      Console.WriteLine( "QTimeout v1.0 (c) 2022 Sensei (aka 'Q')" );
      Console.WriteLine( "Putting a batch script to sleep without an open console (QStart)." );
      Console.WriteLine();
      Console.WriteLine( "Usage:" );
      Console.WriteLine( "QTimeout seconds" );
      Console.WriteLine();
      Console.WriteLine( "Examples:" );
      Console.WriteLine( "QTimeout 1" );
      Console.WriteLine( "QTimeout 5.5" );
   }

   public static void Main( string [] args ) {
      if( args.Length == 1 ) {
         try {
            string arg = args[ 0 ];
            arg = arg.Replace( ',', '.' );
            double delay = Double.Parse( arg, CultureInfo.InvariantCulture );
            if( delay <= 0 ) throw( new FormatException() );
            Thread.Sleep( (int) ( delay * 1000.0 ) );
         } catch( Exception e ) {
            Console.Error.WriteLine( e.Message );
            Environment.Exit( 20 );
         }
      } else {
         Help();
         Environment.Exit( 0 );
      }
   }
}
