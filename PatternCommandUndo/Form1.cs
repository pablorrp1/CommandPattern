using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCommand.Clases_Patron;
using PatternCommand.Clases_Externas;
using System.Windows.Forms;

namespace PatternCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.setCommand(lightOn);
            salida.Text=remote.buttonWasPressed();
            salida.Text += "\n"+remote.undoWasPressed();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RemoteControl remoteControl = new RemoteControl(6);

            Light light = new Light();
            Fan fan = new Fan();

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            FanOnCommand fanOnCommand = new FanOnCommand(fan);
            FanOffCommand fanOffCommand = new FanOffCommand(fan);

            remoteControl.setCommand(0, lightOnCommand, lightOffCommand);
            remoteControl.setCommand(1, fanOnCommand, fanOffCommand);

            salida.Text = remoteControl.toString()+" ";

            salida.Text+= "\n"+remoteControl.onButtonWasPushed(0);
            salida.Text += "\n"+remoteControl.offButtonWasPushed(0);
            salida.Text += "\n" + remoteControl.undoButtonWasPushed();
            salida.Text += "\n" + remoteControl.onButtonWasPushed(1);
            salida.Text += "\n" + remoteControl.offButtonWasPushed(1);
            salida.Text += "\n" + remoteControl.undoButtonWasPushed();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            RemoteControl remoteControl = new RemoteControl(3);

            Light light = new Light();
            Fan fan = new Fan();

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            FanOnCommand fanOnCommand = new FanOnCommand(fan);
            FanOffCommand fanOffCommand = new FanOffCommand(fan);

            Command[] onCommands = { lightOnCommand, fanOnCommand };
            Command[] offCommands = { lightOffCommand, fanOffCommand };

            MacroCommand onMacro = new MacroCommand(onCommands);
            MacroCommand offMacro = new MacroCommand(offCommands);

            remoteControl.setCommand(0, onMacro, offMacro);

            salida.Text = remoteControl.toString() + " ";

            salida.Text += "\n" + remoteControl.onButtonWasPushed(0);
            salida.Text += "\n" + remoteControl.offButtonWasPushed(0);

        }
    }
}
