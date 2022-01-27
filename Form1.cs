using System;
using System.Windows.Forms;
using System.Management;

namespace Лаба_1_ПО
{
    public partial class Form1 : Form
    {
        public string key; //выбор элемента компьютера
        public Form1()
        {
            Log.Write("Debug","Запуск приложения...");
            InitializeComponent();
        }
        
        private void SetInfo(string key)
        {
            dataGridView1.Rows.Clear(); //очистка предыдущей таблицы
            Log.Write("Debug", "Вызов метода заполнения SetInfo");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + key);
            int x = 0; int y = 0;
            foreach (ManagementObject obj in searcher.Get())
            {
                toolStripStatusLabel1.Text = obj["Name"].ToString();
                foreach (PropertyData data in obj.Properties)
                {
                    if (data.Value == null)
                    {
                        continue; //если не нашлось значение св-ва элемента - переход к др.итерации
                    }
                    Log.WriteElement("Info ", "Параметр - "+ data.Name +", его свойство - "+ data.Value +"");
                    dataGridView1.Rows.Add(); //добавление строки
                    dataGridView1.Rows[y].Cells[x].Value = data.Name;
                    dataGridView1.Rows[y].Cells[x + 1].Value = data.Value;
                    y++;                  
                }              
                obj.Dispose(); //освобождение ресурсов
            }
            if (y == 0) //если нету инфы по элементу
            {
                MessageBox.Show("Не удалось получить информацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel1.Text = "Не удалось получить информацию";
                Log.Write("Error", "Нету информации по элементу");
                Log.count--;
            }
            Log.Write("Debug", "Запись данных об элементе "+key+" в отдельный .log файл");
            Log.count++;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            switch(comboBox1.SelectedItem.ToString())
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
            Log.Write("Info ", "Выбор элемента " + key);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SetInfo(key); //вызов функции заполнения
            }
            catch
            {
                MessageBox.Show("Не выбран элемент компьютера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write("Error", "Не был выбран элемент");
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Log.Write("Info ", "Ручная очистка таблицы");
            dataGridView1.Rows.Clear();
        }
    }
}
