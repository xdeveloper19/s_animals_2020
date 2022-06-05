using WpfClientApp.WebAnimalTestService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
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
using System.ComponentModel;

namespace WpfClientApp
{
    /// <summary>
    /// Логика взаимодействия для AnimalPage.xaml
    /// </summary>
    public partial class AnimalPage : Page
    {
		AnimalType type;
		WebAnimalTestService.WebAnimalService service = new WebAnimalTestService.WebAnimalService();
		
		public List<Animal> Animals = new List<Animal>();
		public List<Artiodactyls> Artiodactyls = new List<Artiodactyls>();
		public List<Mammal> Mammals = new List<Mammal>();
		public List<Bird> Birds = new List<Bird>();

		public AnimalPage()
		{
			InitializeComponent();
			var parentWindow = this.Parent as Window;
			NavigationService nav = NavigationService.GetNavigationService(this);

			service.AddAnimalCompleted += Service_AddAnimalCompleted;
			service.AddAtriCompleted += Service_AddAtriCompleted;
			service.AddBirdCompleted += Service_AddBirdCompleted;
			service.AddMammalCompleted += Service_AddMammalCompleted;

			service.GetAnimalsCompleted += Service_GetAnimalsCompleted;
			service.GetArtiCompleted += Service_GetArtiCompleted;
			service.GetBirdsCompleted += Service_GetBirdsCompleted;
			service.GetMammalsCompleted += Service_GetMammalsCompleted;

			service.RemoveAnimalsCompleted += Service_RemoveAnimalsCompleted;
			service.RemoveArtiCompleted += Service_RemoveArtiCompleted;
			service.RemoveBirdsCompleted += Service_RemoveBirdsCompleted;
			service.RemoveMammalsCompleted += Service_RemoveMammalsCompleted;
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

		private void Service_RemoveMammalsCompleted(object sender, WebAnimalTestService.RemoveMammalsCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Список млекопитающих успешно очищен!");
			else
				MessageBox.Show("Ошибка удаления");
		}

		private void Service_RemoveBirdsCompleted(object sender, WebAnimalTestService.RemoveBirdsCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Список птиц успешно очищен!");
			else
				MessageBox.Show("Ошибка удаления");
		}

		private void Service_RemoveArtiCompleted(object sender, WebAnimalTestService.RemoveArtiCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Список парнокопытных успешно очищен!");
			else
				MessageBox.Show("Ошибка удаления");
		}

		private void Service_RemoveAnimalsCompleted(object sender, WebAnimalTestService.RemoveAnimalsCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Список животных успешно очищен!");
			else
				MessageBox.Show("Ошибка удаления");
		}

		private void Service_GetMammalsCompleted(object sender, WebAnimalTestService.GetMammalsCompletedEventArgs e)
		{
			Mammals = e.Result.ToList();
			tb_list.DataContext = Mammals;
		}

		private void Service_GetBirdsCompleted(object sender, WebAnimalTestService.GetBirdsCompletedEventArgs e)
		{
			Birds = e.Result.ToList();
			tb_list.DataContext = Birds;
		}

		private void Service_GetArtiCompleted(object sender, WebAnimalTestService.GetArtiCompletedEventArgs e)
		{
			Artiodactyls = e.Result.ToList();
			tb_list.DataContext = Artiodactyls;
		}

		private void Service_GetAnimalsCompleted(object sender, WebAnimalTestService.GetAnimalsCompletedEventArgs e)
		{
			Animals = e.Result.ToList();
			tb_list.DataContext = Animals;
		}

		private void Service_AddMammalCompleted(object sender, WebAnimalTestService.AddMammalCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Млекопитающее успешно добавлено!");
			else
				MessageBox.Show("Ошибка добавления");
		}

		private void Service_AddBirdCompleted(object sender, WebAnimalTestService.AddBirdCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Птица успешно добавлена!");
			else
				MessageBox.Show("Ошибка добавления");
		}

		private void Service_AddAtriCompleted(object sender, WebAnimalTestService.AddAtriCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Парнокопытное успешно добавлено!");
			else
				MessageBox.Show("Ошибка добавления");
		}

		private void Service_AddAnimalCompleted(object sender, WebAnimalTestService.AddAnimalCompletedEventArgs e)
		{
			if (e.Result == true)
				MessageBox.Show("Животное успешно добавлено!");
			else
				MessageBox.Show("Ошибка добавления");
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
					    service.AddAnimal(animal.Name, animal.Age, animal.Weight);
						service.GetAnimalsAsync();

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
						service.AddMammal(animal.Name, animal.Temperature, animal.IsSwimming);
						service.GetMammalsAsync();

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
						service.AddAtri(animal.Name, animal.Hoofs, animal.IsRum);
						service.GetArtiAsync();

						tb_list.DataContext = Artiodactyls.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				case AnimalType.Bird:
					{
						Bird animal = new Bird();
						animal.Wings = (edit_second.Text == "черный") ? WebAnimalTestService.Color.Black : (edit_second.Text == "белый") ? WebAnimalTestService.Color.White :
							(edit_second.Text == "разноцветный") ? WebAnimalTestService.Color.Multicolored : WebAnimalTestService.Color.Black;
						animal.Name = edit_first.Text;
						animal.IsTalking = (edit_third.Text == "да") ? true : false;

						Birds.Add(animal);
						service.AddBird(animal.Name, animal.Wings, animal.IsTalking);
						service.GetBirdsAsync();

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
						service.GetAnimalsAsync();
					}
					break;
				case AnimalType.Mammal:
					{
						service.GetMammalsAsync();
					}
					break;
				case AnimalType.Anti:
					{
						service.GetArtiAsync();
					}
					break;
				case AnimalType.Bird:
					{
						service.GetBirdsAsync();
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
						service.RemoveAnimalsAsync();
						tb_list.DataContext = Animals.ToList();
					}
					break;
				case AnimalType.Mammal:
					{
						Mammals = new List<Mammal>();
						service.RemoveMammalsAsync();
						tb_list.DataContext = Mammals.ToList();
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls = new List<Artiodactyls>();
						service.RemoveArtiAsync();
						tb_list.DataContext = Artiodactyls.ToList();
					}
					break;
				case AnimalType.Bird:
					{
						Birds = new List<Bird>();
						service.RemoveBirdsAsync();
						tb_list.DataContext = Birds.ToList();
					}
					break;
				default:
					break;
			}
		}
	}
}
