using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    
    public partial class Window : Form
    {
        // Список создаваемых объектов 
        List<object> list = new List<object>();

        public delegate void MakeObj(int[] data);
        
        // Массив делегатов функций, создающих объекты выбранного класса
        MakeObj[] functions = new MakeObj[7];

        // 7 делегатов, создающих объекты выбранного класса
        public void MakeCustomer(int[] data) {
            Customer cust = new Customer(data[0]);
            list.Add(cust);
            DGV.Rows.Add(list.Count,"Покупатель", cust.budget, "-", "-", "-", "-", "-", "-", "-");
        }

        public void MakeEmployee(int[] data) {
            Employee emp = new Employee(data[0], data[1]);
            list.Add(emp);
            DGV.Rows.Add(list.Count, "Служащий", emp.cust.budget, emp.salary, "-", "-", "-", "-", "-", "-");
        }

        public void MakeCleaner(int[] data) {
            Cleaner cl = new Cleaner(data[0], data[1], data[2]);
            list.Add(cl);
            DGV.Rows.Add(list.Count, "Уборщик", cl.cust.budget, cl.salary, cl.amount_of_washed_rooms, "-", "-", "-", "-", "-");
        }

        public void MakeCasher(int[] data) {
            Casher cash = new Casher(data[0], data[1], data[3]);
            list.Add(cash);
            DGV.Rows.Add(list.Count, "Кассир", cash.cust.budget, cash.salary, "-", cash.gain, "-", "-", "-", "-");
        }

        public void MakeSeniorCasher(int[] data) {
            SeniorCasher s_cash = new SeniorCasher(data[0], data[1], data[3], data[4]);
            list.Add(s_cash);
            DGV.Rows.Add(list.Count, "Старший кассир", s_cash.cust.budget, s_cash.salary, "-", s_cash.gain, s_cash.amountOfJuniors, "-", "-", "-");
        }

        public void MakeManager(int[] data) {
            Manager mng = new Manager(data[0], data[1], data[5]);
            list.Add(mng);
            DGV.Rows.Add(list.Count, "Менеджер", mng.cust.budget, mng.salary, "-", "-", "-", mng.employees, "-", "-");
        }

        public void MakeDirector(int[] data) {
            Director dir = new Director(data[0], data[1], data[5], data[6], data[7]);
            list.Add(dir);
            DGV.Rows.Add(list.Count, "Директор", dir.cust.budget, dir.salary, "-", "-", "-", dir.employees, dir.goal, dir.realGain);
        }
          
        // Фукнция получения данных, введенных пользователем
        public int[] GetData()
        {
            int[] data = new int[8];

            int.TryParse(TBBudget.Text, out data[0]);
            int.TryParse(TBSalary.Text, out data[1]);
            int.TryParse(TBRooms.Text, out data[2]);
            int.TryParse(TBGainADay.Text, out data[3]);
            int.TryParse(TBCashers.Text, out data[4]);
            int.TryParse(TBEmployees.Text, out data[5]);
            int.TryParse(TBGoal.Text, out data[6]);
            int.TryParse(TBRealGain.Text, out data[7]);

            return data;
        }

        public Window()
        {
            InitializeComponent();
            
            // Инициализация данных
            functions[0] = MakeCustomer;
            functions[1] = MakeEmployee;
            functions[2] = MakeCleaner;
            functions[3] = MakeCasher;
            functions[4] = MakeSeniorCasher;
            functions[5] = MakeManager;
            functions[6] = MakeDirector;
        }
        
        // Нажатие на кнопку "Создать объект"
        private void BCreateClass_Click(object sender, EventArgs e)
        {
            //ItemNum - номер создаваемого объекта
            int i, itemNum;
            // Введенные пользователем данные
            int[] data = new int[8]; 

            if ((itemNum = CBClasses.SelectedIndex) < 0)
            {
                MessageBox.Show("Вы должны выбрать тип создаваемого объекта", "Ошибка");
                return;
            }

            // Получение данных, введенных пользователем
            data = GetData();

            Employee emp1 = new Employee();
            functions[itemNum](data);
            

        }
        // Нажатие на кнопку "Редактировать объект"
        private void BEdit_Click(object sender, EventArgs e)
        {
            int num;
            // Введенные пользователем данные
            int[] data = new int[8]; 

            if (!int.TryParse(TBEditNum.Text, out num))
            {
                MessageBox.Show("Некорректный номер редактируемого элемента", "Ошибка");
                return;
            }
            if (num > list.Count || num <= 0)
            {
                MessageBox.Show("Некорректный номер редактируемого элемента", "Ошибка");
                return;
            }

            // Получение данных, введенных пользователем
            data = GetData();

            if (list[num - 1] is Customer)
            {
               ((Customer)list[num - 1]).budget = data[0];
                DGV.Rows.RemoveAt(num - 1);
                DGV.Rows.Insert(num-1, num, "Покупатель", ((Customer)list[num - 1]).budget, "-", "-", "-", "-", "-", "-", "-");
                return;
            }
            if (list[num - 1] is Director)
            {
                ((Director)list[num - 1]).cust.budget = data[0];
                ((Director)list[num - 1]).salary = data[1];
                ((Director)list[num - 1]).employees = data[5];
                ((Director)list[num - 1]).goal = data[6];
                ((Director)list[num - 1]).realGain = data[7];
                DGV.Rows.RemoveAt(num - 1);
                DGV.Rows.Insert(num - 1, num, "Директор", ((Director)list[num - 1]).cust.budget, ((Director)list[num - 1]).salary, "-", "-", "-",
                    ((Director)list[num - 1]).employees, ((Director)list[num - 1]).goal, ((Director)list[num - 1]).realGain);
                return;
            }
            if (list[num - 1] is Manager)
            {
                ((Manager)list[num - 1]).cust.budget = data[0];
                ((Manager)list[num - 1]).salary = data[1];
                ((Manager)list[num - 1]).employees = data[5];
                DGV.Rows.RemoveAt(num - 1);
                DGV.Rows.Insert(num - 1, num, "Менеджер", ((Manager)list[num - 1]).cust.budget, ((Manager)list[num - 1]).salary, "-", "-", "-", ((Manager)list[num - 1]).employees, "-", "-");
                return;
            }
            if (list[num - 1] is SeniorCasher)
            {
                ((SeniorCasher)list[num - 1]).cust.budget = data[0];
                ((SeniorCasher)list[num - 1]).salary = data[1];
                ((SeniorCasher)list[num - 1]).gain = data[3];
                ((SeniorCasher)list[num - 1]).amountOfJuniors = data[4];
                DGV.Rows.RemoveAt(num - 1);
                DGV.Rows.Insert(num - 1, num, "Старший кассир", ((SeniorCasher)list[num - 1]).cust.budget, ((SeniorCasher)list[num - 1]).salary, "-", ((SeniorCasher)list[num - 1]).gain,
                    ((SeniorCasher)list[num - 1]).amountOfJuniors, "-", "-", "-");
                return;
            }
            if (list[num - 1] is Casher)
            {
                ((Casher)list[num - 1]).cust.budget = data[0];
                ((Casher)list[num - 1]).salary = data[1];
                ((Casher)list[num - 1]).gain = data[3];
                DGV.Rows.RemoveAt(num - 1);
                DGV.Rows.Insert(num - 1, num, "Кассир", ((Casher)list[num - 1]).cust.budget, ((Casher)list[num - 1]).salary, "-", ((Casher)list[num - 1]).gain, "-", "-", "-", "-");
                return;
            }
            if (list[num - 1] is Cleaner)
            {
                ((Cleaner)list[num - 1]).cust.budget = data[0];
                ((Cleaner)list[num - 1]).salary = data[1];
                ((Cleaner)list[num - 1]).amount_of_washed_rooms = data[2];
                DGV.Rows.RemoveAt(num - 1);
                DGV.Rows.Insert(num - 1, num, "Уборщик", ((Cleaner)list[num - 1]).cust.budget, ((Cleaner)list[num - 1]).salary, ((Cleaner)list[num - 1]).amount_of_washed_rooms, "-", "-", "-", "-", "-");
                return;
            }
            if (list[num - 1] is Employee)
            {
                ((Employee)list[num - 1]).cust.budget = data[0];
                ((Employee)list[num - 1]).salary = data[1];
                DGV.Rows.RemoveAt(num - 1);
                DGV.Rows.Insert(num - 1, num, "Служащий", ((Employee)list[num - 1]).cust.budget, ((Employee)list[num - 1]).salary, "-", "-", "-", "-", "-", "-");
                return;
            }           
        }

        // Нажатие на кнопку "Удалить объект"
        private void BDelete_Click(object sender, EventArgs e)
        {
            int num;

            if (!int.TryParse(TBDelete.Text, out num))
            {
                MessageBox.Show("Некорректный номер удаляемого элемента", "Ошибка");
                return;
            }
            if (num > list.Count || num <= 0)
            {
                MessageBox.Show("Некорректный номер удаляемого элемента", "Ошибка");
                return;
            }

            list.RemoveAt(num - 1);
            DGV.Rows.RemoveAt(num - 1);
            for (int i = num - 1; i < DGV.Rows.Count; i++)
                DGV.Rows[i].Cells[0].Value = i + 1;
        }
    }
}
