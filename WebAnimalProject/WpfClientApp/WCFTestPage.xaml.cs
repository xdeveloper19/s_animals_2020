using AnimalsEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfClientApp.HomePage;

namespace WpfClientApp
{
    /// <summary>
    /// Логика взаимодействия для WCFTestPage.xaml
    /// </summary>
    public partial class WCFTestPage : Page
    {
		AnimalType type;
		AnimalServiceReference.WCFAnimalServiceClient client = new AnimalServiceReference.WCFAnimalServiceClient();

		public List<Animal> Animals = new List<Animal>();
		public List<Artiodactyls> Artiodactyls = new List<Artiodactyls>();
		public List<Mammal> Mammals = new List<Mammal>();
		public List<Bird> Birds = new List<Bird>();

		public WCFTestPage()
		{
			InitializeComponent();
			var parentWindow = this.Parent as Window;
			NavigationService nav = NavigationService.GetNavigationService(this);

			//if (parentWindow != null)
			//	parentWindow.Loaded += ParentWindow_Loaded;
			//this.NavigationService.LoadCompleted += NavigationService_LoadCompleted;

			type = StaticAnimal.TypeOfAnimal;

			switch (type)
			{
				case AnimalType.Animal:
					{
						txt_first.Text = "Введите наименование";
						txt_second.Text = "Введите вес, кг";
						txt_third.Text = "Введите возраст";
					}
					break;
				case AnimalType.Mammal:
					{
						txt_first.Text = "Введите наименование";
						txt_second.Text = "Введите температуру тела в цельсиях";
						txt_third.Text = "Животное умеет плавать? да, нет";
					}
					break;
				case AnimalType.Anti:
					{
						txt_first.Text = "Введите наименование";
						txt_second.Text = "Введите количество копыт";
						txt_third.Text = "Животное жвачное? да, нет";
					}
					break;
				case AnimalType.Bird:
					{
						txt_first.Text = "Введите наименование";
						txt_second.Text = "Введите окраску крыльев";
						txt_third.Text = "Птица говорящая? да, нет";
					}
					break;
				default:
					break;
			}
		}

		private void Button_Add(object sender, RoutedEventArgs e)
		{
			AddInfo();
		}

		private void AddInfo()
		{
			if (string.IsNullOrWhiteSpace(txt_first.Text) || string.IsNullOrWhiteSpace(txt_second.Text)
				|| string.IsNullOrWhiteSpace(txt_third.Text))
			{
				MessageBox.Show("Введите все данные");
				return;
			}

			switch (type)
			{
				case AnimalType.Animal:
					{
						Animal animal = new Animal();
						animal.Age = int.Parse(edit_third.Text);
						animal.Name = edit_first.Text;
						animal.Weight = int.Parse(edit_second.Text);

						Animals.Add(animal);
						client.AddAnimal(animal.Name, animal.Age, animal.Weight);
						Animals = client.GetAnimals().ToList();

						tb_list.DataContext = Animals.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				case AnimalType.Mammal:
					{
						Mammal animal = new Mammal();
						animal.Temperature = int.Parse(edit_second.Text);
						animal.Name = edit_first.Text;
						animal.IsSwimming = (edit_third.Text == "да") ? true : false;

						Mammals.Add(animal);
						client.AddMammal(animal.Name, animal.Temperature, animal.IsSwimming);
						Mammals = client.GetMammals().ToList();

						tb_list.DataContext = Mammals.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls animal = new Artiodactyls();
						animal.IsRum = (edit_third.Text == "да") ? true : false;
						animal.Name = edit_first.Text;
						animal.Hoofs = int.Parse(edit_second.Text);

						Artiodactyls.Add(animal);
						client.AddAtri(animal.Name, animal.Hoofs, animal.IsRum);
						Artiodactyls =  client.GetArti().ToList();

						tb_list.DataContext = Artiodactyls.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				case AnimalType.Bird:
					{
						Bird animal = new Bird();
						animal.Wings = (edit_second.Text == "черный") ? AnimalsEntity.Color.Black : (edit_second.Text == "белый") ? AnimalsEntity.Color.White :
							(edit_second.Text == "разноцветный") ? AnimalsEntity.Color.Multicolored : AnimalsEntity.Color.Black;
						animal.Name = edit_first.Text;
						animal.IsTalking = (edit_third.Text == "да") ? true : false;

						Birds.Add(animal);
						client.AddBird(animal.Name, animal.Wings, animal.IsTalking);
						Birds =  client.GetBirds().ToList();

						tb_list.DataContext = Birds.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				default:
					break;
			}
		}

		private void Button_Load(object sender, RoutedEventArgs e)
		{
			LoadInfo();
		}

		private void LoadInfo()
		{
			switch (type)
			{
				case AnimalType.Animal:
					{
						Animals = client.GetAnimals().ToList();
						tb_list.DataContext = Animals.ToList();
					}
					break;
				case AnimalType.Mammal:
					{
						Mammals = client.GetMammals().ToList();
						tb_list.DataContext = Mammals.ToList();
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls = client.GetArti().ToList();
						tb_list.DataContext = Artiodactyls.ToList();
					}
					break;
				case AnimalType.Bird:
					{
						Birds = client.GetBirds().ToList();
						tb_list.DataContext = Birds.ToList();
					}
					break;
				default:
					break;
			}
		}

		private void Button_Search(object sender, RoutedEventArgs e)
		{
			switch (type)
			{
				case AnimalType.Animal:
					{
						BindingList<Animal> BS = new BindingList<Animal>(Animals.Where(m => m.Age.ToString().Contains(edit_search.Text) || m.Name.ToLower().Contains(edit_search.Text.ToLower()) || m.Weight.ToString().Contains(edit_search.Text)).ToList());
						tb_list.DataContext = BS;
					}
					break;
				case AnimalType.Mammal:
					{
						BindingList<Mammal> BS = new BindingList<Mammal>(Mammals.Where(m => m.Name.ToLower().Contains(edit_search.Text.ToLower())).ToList());
						tb_list.DataContext = BS;
					}
					break;
				case AnimalType.Anti:
					{
						BindingList<Artiodactyls> BS = new BindingList<Artiodactyls>(Artiodactyls.Where(m => m.Name.ToLower().Contains(edit_search.Text.ToLower())).ToList());
						tb_list.DataContext = BS;
					}
					break;
				case AnimalType.Bird:
					{
						BindingList<Bird> BS = new BindingList<Bird>(Birds.Where(m => m.Name.ToLower().Contains(edit_search.Text.ToLower())).ToList());
						tb_list.DataContext = BS;
					}
					break;
				default:
					break;
			}
		}

		private void Button_Delete(object sender, RoutedEventArgs e)
		{
			switch (type)
			{
				case AnimalType.Animal:
					{
						Animals = new List<Animal>();
						bool result = client.RemoveAnimals();
						if (result)
							MessageBox.Show("Успешно!");
						else
							MessageBox.Show("Что-то пошло не так..");
						tb_list.DataContext = Animals.ToList();
					}
					break;
				case AnimalType.Mammal:
					{
						Mammals = new List<Mammal>();
						bool result = client.RemoveMammals();
						if (result)
							MessageBox.Show("Успешно!");
						else
							MessageBox.Show("Что-то пошло не так..");
						tb_list.DataContext = Mammals.ToList();
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls = new List<Artiodactyls>();
						bool result = client.RemoveArti();
						if (result)
							MessageBox.Show("Успешно!");
						else
							MessageBox.Show("Что-то пошло не так..");
						tb_list.DataContext = Artiodactyls.ToList();
					}
					break;
				case AnimalType.Bird:
					{
						Birds = new List<Bird>();
						bool result = client.RemoveBirds();
						if (result)
							MessageBox.Show("Успешно!");
						else
							MessageBox.Show("Что-то пошло не так..");
						tb_list.DataContext = Birds.ToList();
					}
					break;
				default:
					break;
			}
		}

	}
}
