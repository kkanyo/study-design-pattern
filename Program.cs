using CS_Study.Chapter01;
using CS_Study.Chapter02;
using CS_Study.Chapter03;
using CS_Study.Chapter04;
using CS_Study.Chapter05;
using CS_Study.Chapter06;

namespace CS_Study
{
    class Program
    {
        static void Main( string[] args )
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light( "Living Room" );
            CeilingFan ceilingFan = new CeilingFan( "Living Room" );
            Stereo stereo = new Stereo( "Living Room" );

            LightOnCommand lightOn = 
                new LightOnCommand( light );
            CeilingFanHighCommand ceilingFanHigh =
                new CeilingFanHighCommand( ceilingFan );
            StereoOnWithCDCommand stereoOnWithCD =
                new StereoOnWithCDCommand( stereo );

            LightOffCommand lightOff =
                new LightOffCommand( light );
            CeilingFanHighCommand ceilingFanOff =
                new CeilingFanHighCommand( ceilingFan );

            Command[] partyOn = 
                { lightOn, ceilingFanHigh, stereoOnWithCD };
            Command[] partyOff =
                { lightOff, ceilingFanOff };

            MacroCommand partyOnMacro = new MacroCommand( partyOn );
            MacroCommand partyOffMacro = new MacroCommand( partyOff );

            remoteControl.SetCommand( 0, partyOnMacro, partyOffMacro );

            Console.WriteLine( remoteControl );
            Console.WriteLine( "----- Macro On -----" );
            remoteControl.OnButtonWasPushed( 0 );
            Console.WriteLine( "----- Macro Off -----" );
            remoteControl.OffButtonWasPushed( 0 );

        }
    }
}