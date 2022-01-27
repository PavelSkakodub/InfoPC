using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using NLog;

namespace SPO_Wind_Form_Lab1
{
    public partial class Form1 : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            logger.Info("info message");
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) 
        {
            SelectedElement.SelectedIndex = 0; 
        }
        private void GetHardWareInfo(string key, ListView list)
        {
            list.Items.Clear();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + key);
            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj.Properties.Count == 0)
                    {
                       MessageBox.Show("Не удалось получить информацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ListViewGroup listViewGroup;
                    try
                    {
                        listViewGroup = list.Groups.Add(obj["Name"].ToString(),
                        obj["Name"].ToString());
                    }
                    catch (Exception ex)
                    {
                        listViewGroup = list.Groups.Add(obj.ToString(), obj.ToString());
                    }
                    foreach (PropertyData data in obj.Properties)
                    {
                        ListViewItem item = new ListViewItem(listViewGroup);
                        if (list.Items.Count % 2 == 0)
                        {
                            item.BackColor = Color.WhiteSmoke;
                        }
                        item.Text = data.Name;
                        
                        if (data.Value != null && !string.IsNullOrEmpty(data.Value.ToString()))
                        {
                            string resStr = string.Empty;
                            switch (data.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] stringData = data.Value as string[];
                                    //string resStr1 = string.Empty;
                                    foreach (string s in stringData)
                                    {
                                        resStr += s + " ";
                                    }
                                    item.SubItems.Add(resStr);
                                    break;
                                case "System.UInt16[]":
                                    ushort[] ushortData = data.Value as ushort[];
                                    //string resStr2 = string.Empty;
                                    foreach (ushort us in ushortData)
                                    {
                                        resStr += us.ToString() + " ";
                                    }
                                    item.SubItems.Add(resStr);
                                    break;
                                default:
                                    item.SubItems.Add(data.Value.ToString());
                                    break;
                            }
                            list.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void SelectedElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = string.Empty;
            switch (SelectedElement.SelectedItem.ToString())
            {
                case "Процессор":
                    key = "Win32_Processor";
                    break;
                case "Видеокарта":
                    key = "Win32_VideoController";
                    break;
                case "Чипсет":
                    key = "Win32_IDEController";
                    break;
                case "Батарея":
                    key = "Win32_Battery";
                    break;
                case "Биос":
                    key = "Win32_BIOS";
                    break;
                case "Оперативная память":
                    key = "Win32_PhysicalMemory";
                    break;
                case "Кэш":
                    key = "Win32_CacheMemory";
                    break;
                case "USB":
                    key = "Win32_USBController";
                    break;
                case "Диск":
                    key = "Win32_DiskDrive";
                    break;
                case "Логические диски":
                    key = "Win32_LogicalDisk";
                    break;
                case "Клавиатура":
                    key = "Win32_Keyboard";
                    break;
                case "Сеть":
                    key = "Win32_NetworkAdapter";
                    break;
                case "Пользователь":
                    key = "Win32_Account";
                    break;
                default:
                    key = "Win32_Processor";
                    break;
            }
            GetHardWareInfo(key, listView1);
        }

        private void toolStripButtonMetro_Click(object sender, EventArgs e)
        {
            logger.Trace("button1 is pressed");
            new FormSystemMonitor().ShowDialog();
        }
    }
}
