using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OS_MemoryBF_FF
{
    public partial class Form1 : Form
    {
        int PID = 0;
        bool[] memory;
        List<Process> PList;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            txtBox_ProcessSize.Enabled = true;
            txtBox_DisplayMemory.Enabled = true;
            btn_DisplayMemory.Enabled = true;
            btn_Add.Enabled = true;

            PList = new List<Process>();
            memory = new bool[Convert.ToInt32(txtBox_MemorySize.Text)];
            for (int i = 0; i < memory.Length; i++)
            {
                memory[i] = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e) //Alocation
        {
            if (cmbBox_Algorithm.SelectedItem.ToString() == "Best Fit")
            {
                //Best Fit
                txtBox_ProcessID.Enabled = true;
                btn_Remove.Enabled = true;
                Process P = new Process();
                P.length = Convert.ToInt32(txtBox_ProcessSize.Text);
                P.ID = ++PID; //processes take IDs starts from 1 , 2, ..
                int counter = 0;
                int i;
                //checks the memory array
                List<Hole> holes = new List<Hole>();

                //counts all the holes and adds them to the holes list
                for (i = 0; i < memory.Length; i++)
                {
                    Hole temp = new Hole();
                    if (memory[i] == false)
                        counter++;
                    else
                    {
                        if (counter != 0)
                        {
                            temp.value = counter;
                            temp.endIndex = i - 1;
                            temp.getstart();
                            holes.Add(temp);
                        }
                        counter = 0;
                    }
                }
                if (memory[i - 1] == false)
                {
                    Hole temp = new Hole();
                    temp.value = counter;
                    temp.endIndex = i - 1;
                    temp.getstart();
                    holes.Add(temp);
                }

                //sort the holes list so that first is the smallest
                for (int a = 0; a < holes.Count; a++)
                {
                    for (int b = a; b < holes.Count; b++)
                    {
                        Hole tc = new Hole();
                        if (holes[a].value > holes[b].value)
                        {
                            tc.value = holes[a].value;
                            tc.endIndex = holes[a].endIndex;
                            tc.startIndex = holes[a].startIndex;

                            holes[a].value = holes[b].value;
                            holes[a].startIndex = holes[b].startIndex;
                            holes[a].endIndex = holes[b].endIndex;

                            holes[b].value = tc.value;
                            holes[b].startIndex = tc.startIndex;
                            holes[b].endIndex = tc.endIndex;
                        }
                    }
                }

                //doing best fit 
                //---------------
                bool isthere = false;
                foreach (Hole item in holes)
                {
                    if (P.length <= item.value)
                    {
                        P.startIndex = item.startIndex;
                        P.endIndex = item.startIndex + (P.length - 1);
                        PList.Add(P);
                        isthere = true;
                        for (int n = item.startIndex; n <= P.endIndex; n++)
                        {
                            memory[n] = true;
                        }
                        txtBox_State.Text = "Process : " + PID.ToString() + " has been Added";
                        break;
                    }
                }
                //if there's no place for that size 
                if (!isthere)
                {
                    txtBox_State.Text = "No place!";
                    return;
                }
            }
            else
            {
                //First Fit
                txtBox_ProcessID.Enabled = true;
                btn_Remove.Enabled = true;
                Process P = new Process();
                P.length = Convert.ToInt32(txtBox_ProcessSize.Text);
                P.ID = ++PID;
                int counter = 0;
                int i;
                //checks the memory array
                for (i = 0; i < memory.Length; i++)
                {
                    if (memory[i] == false)
                        counter++;
                    else
                        counter = 0;
                    if (counter == P.length)
                        break;
                }
                //if there's no place for that size 
                if (counter != P.length)
                {
                    txtBox_State.Text = "No place!";
                    return;
                }

                //fill in the Process data
                P.endIndex = i;
                P.startIndex = i - (P.length - 1);

                //fill in the memory array with trues
                for (int j = P.startIndex; j <= P.endIndex; j++)
                {
                    memory[j] = true;
                }

                //Add to the process list
                PList.Add(P);
                txtBox_State.Text = "Process : " + PID.ToString() + " has been Added";
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            //Deallocation 
            bool check = false;
            for (int i = 0; i < PList.Count; i++)
            {
                if (PList[i].ID == Convert.ToInt32(txtBox_ProcessID.Text))
                {
                    check = true;
                    for (int j = PList[i].startIndex; j <= PList[i].endIndex; j++)
                    {
                        memory[j] = false;
                    }
                    PList.Remove(PList[i]);
                    break;
                }
            }
            if (check)
                txtBox_State.Text = "Process : " + txtBox_ProcessID.Text + " has been Deleted";
        }

        private List<Process> sort(List<Process> temp)
        {

            List<Process> result = new List<Process>();
            int[] comparer = new int[PList.Count];
            int i = 0;
            foreach (Process t in temp)
            {
                comparer[i] = t.startIndex;
                i++;
            }
            int t1 = 0;
            for (i = 0; i < comparer.Length; i++)
            {
                for (int j = i; j < comparer.Length; j++)
                {
                    if (comparer[i] > comparer[j])
                    {
                        t1 = comparer[i];
                        comparer[i] = comparer[j];
                        comparer[j] = t1;
                    }
                }
            }
            foreach (int k in comparer)
            {
                Process st = new Process();
                foreach (Process t in temp)
                {
                    if (t.startIndex == k)
                    {
                        st.ID = t.ID;
                        st.length = t.length;
                        st.startIndex = t.startIndex;
                        st.endIndex = t.endIndex;
                    }
                }
                result.Add(st);
            }
            return result;
        }

        private void btn_DisplayMemory_Click(object sender, EventArgs e)
        {
            txtBox_DisplayMemory.Text = "";
            List<Process> ret = new List<Process>();
            ret = sort(PList);
            int lastindex = -1; //to store last full index in memory

            foreach (Process item in ret)
            {
                if (lastindex + 1 != item.startIndex)
                    txtBox_DisplayMemory.Text += "*******HOLE*******\r\n";
                txtBox_DisplayMemory.Text += "Location : " + "( " + item.startIndex.ToString() + " --> " + item.endIndex.ToString() + " )" + " PID : " + "( " + item.ID + " )" + "\r\n";
                lastindex = item.endIndex;
            }
            if (lastindex != memory.Length - 1)
                txtBox_DisplayMemory.Text += "*******HOLE*******";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PID = 0;
        }

    }
}
