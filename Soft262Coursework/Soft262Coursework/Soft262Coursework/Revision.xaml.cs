using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Soft262Coursework
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Revision : ContentPage
    {
        public Revision()
        {
            InitializeComponent();
            //listView.ItemTemplate = new DataTemplate(typeof());
            listView.ItemTapped += async (sender, e) => {
                if (e.Item.ToString() == "Input device")
                {
                    await DisplayAlert("Input device", "An input device is any hardware device that sends data to a computer, allowing you to interact with and control it.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "Output device")
                {
                    await DisplayAlert("Output device", "An output device is any peripheral that receives data from a computer, usually for display, projection, or physical reproduction.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "Motherboard")
                {
                    await DisplayAlert("Motherboard", "Alternatively referred to as the mb, mainboard, mboard, mobo, mobd, backplane board, base board, main circuit board, planar board, system board, or a logic board on Apple computers. The motherboard is a printed circuit board and foundation of a computer that is the biggest board in a computer chassis. It allocates power and allows communication to and between the CPU, RAM, and all other computer hardware components.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "Storage device")
                {
                    await DisplayAlert("Storage device", "Alternatively referred to as digital storage, storage, storage media, or storage medium, a storage device is any hardware capable of holding information either temporarily or permanently.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "Hard drive")
                {
                    await DisplayAlert("Hard drive", "A hard disk drive (sometimes abbreviated as a hard drive, HD, or HDD) is a non-volatile data storage device. It is usually installed internally in a computer, attached directly to the disk controller of the computer's motherboard. It contains one or more platters, housed inside of an air-sealed casing. Data is written to the platters using a magnetic head, which moves rapidly over them as they spin.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "RAM")
                {
                    await DisplayAlert("RAM", "Alternatively referred to as main memory, primary memory, or system memory, RAM (random-access memory) is a hardware device that allows information to be stored and retrieved on a computer. RAM is usually associated with DRAM, which is a type of memory module. Because information is accessed randomly instead of sequentially like it is on a CD or hard drive, access times are much faster. However, unlike ROM, RAM is a volatile memory and requires power to keep the data accessible. If the computer is turned off, all data contained in RAM is lost.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "Hardware")
                {
                    await DisplayAlert("Hardware", "Abbreviated as HW, hardware is best described as any physical component of a computer system that contains a circuit board, ICs, or other electronics. A perfect example of hardware is the screen on which you are viewing this page.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "Software")
                {
                    await DisplayAlert("Software", "Sometimes abbreviated as SW and S/W, software is a collection of instructions that enable the user to interact with a computer, its hardware, or perform tasks. Without software, most computers would be useless.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }
                else if (e.Item.ToString() == "CPU")
                {
                    await DisplayAlert("CPU", "Alternately referred to as a processor, central processor, or microprocessor, the CPU (pronounced sea-pea-you) is the central processing unit of the computer. A computer's CPU handles all instructions it receives from hardware and software running on the computer.", "OK");
                    ((ListView)sender).SelectedItem = null;
                }


            };
            
        }
    }
}