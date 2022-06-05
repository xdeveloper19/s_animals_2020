using AnimalsEntity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using static WpfAnimalsProject.HomePage;

namespace WpfAnimalsProject
{
    /// <summary>
    /// Логика взаимодействия для AnimalPage.xaml
    /// </summary>
    public partial class AnimalPage : Page
    {
        AnimalType type;

		public List<Animal> Animals = new List<Animal>();
		public List<Artiodactyls> Artiodactyls = new List<Artiodactyls>();
		public List<Mammal> Mammals = new List<Mammal>();
		public List<Bird> Birds = new List<Bird>();

		FileData<Animal> animal_data;
		FileData<Bird> bird_data;
		FileData<Artiodactyls> arti_data;
		FileData<Mammal> mammal_data;

		public AnimalPage()
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
						animal_data = new FileData<Animal>(Animals, "animals.xml");
						txt_first.Text = "Введите наименование";
						txt_second.Text = "Введите вес, кг";
						txt_third.Text = "Введите возраст";
					}
					break;
				case AnimalType.Mammal:
					{
						mammal_data = new FileData<Mammal>(Mammals, "mammals.xml");
						txt_first.Text = "Введите наименование";
						txt_second.Text = "Введите температуру тела";
						txt_third.Text = "Животное умеет плавать? да, нет";
					}
					break;
				case AnimalType.Anti:
					{
						arti_data = new FileData<Artiodactyls>(Artiodactyls, "arti.xml");
						txt_first.Text = "Введите наименование";
						txt_second.Text = "Введите количество копыт";
						txt_third.Text = "Животное жвачное? да, нет";
					}
					break;
				case AnimalType.Bird:
					{
						bird_data = new FileData<Bird>(Birds, "birds.xml");
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

		private async void AddInfo()
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
						Animals = await animal_data.Deserialize();
						Animal animal = new Animal();

						animal.Age = int.Parse(edit_third.Text);
						animal.Name = edit_first.Text;
						animal.Weight = int.Parse(edit_second.Text);

						Animals.Add(animal);
						animal_data.objects = Animals;
					    animal_data.XmlSerialize();

						tb_list.DataContext = Animals.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				case AnimalType.Mammal:
					{
						Mammals = await mammal_data.Deserialize();
						Mammal animal = new Mammal();

						animal.Temperature = int.Parse(edit_second.Text);
						animal.Name = edit_first.Text;
						animal.IsSwimming = (edit_third.Text == "да")? true: false;

						Mammals.Add(animal);
						mammal_data.objects = Mammals;
						mammal_data.XmlSerialize();

						tb_list.DataContext = Mammals.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls = await arti_data.Deserialize();
						Artiodactyls animal = new Artiodactyls();

						animal.IsRum = (edit_third.Text == "да") ? true : false;
						animal.Name = edit_first.Text;
						animal.Hoofs= int.Parse(edit_second.Text);

						Artiodactyls.Add(animal);
						arti_data.objects = Artiodactyls;
						arti_data.XmlSerialize();

						tb_list.DataContext = Artiodactyls.ToList();
						edit_first.Text = "";
						edit_second.Text = "";
						edit_third.Text = "";
					}
					break;
				case AnimalType.Bird:
					{
						Birds = await bird_data.Deserialize();
						Bird animal = new Bird();

						animal.Wings = (edit_second.Text == "черный") ? Color.Black : (edit_second.Text == "белый") ? Color.White :
							(edit_second.Text == "разноцветный") ? Color.Multicolored : Color.Black;
						animal.Name = edit_first.Text;
						animal.IsTalking = (edit_third.Text == "да") ? true : false;

						Birds.Add(animal);
						bird_data.objects = Birds;
						bird_data.XmlSerialize();

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

		private void Button_Save(object sender, RoutedEventArgs e)
		{
			switch (type)
			{
				case AnimalType.Animal:
					{
						Animals = tb_list.Items.OfType<Animal>().ToList();
						animal_data.objects = Animals;
						animal_data.XmlSerialize();
					}
					break;
				case AnimalType.Mammal:
					{
						Mammals = tb_list.Items.OfType<Mammal>().ToList();
						mammal_data.objects = Mammals;
						mammal_data.XmlSerialize();
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls = tb_list.Items.OfType<Artiodactyls>().ToList();
						arti_data.objects = Artiodactyls;
						arti_data.XmlSerialize();
					}
					break;
				case AnimalType.Bird:
					{
						Birds = tb_list.Items.OfType<Bird>().ToList();
						bird_data.objects = Birds;
						bird_data.XmlSerialize();
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

		private async void LoadInfo()
		{
			switch (type)
			{
				case AnimalType.Animal:
					{
						Animals = await animal_data.Deserialize();
						tb_list.DataContext = Animals.ToList();
					}
					break;
				case AnimalType.Mammal:
					{
						Mammals = await mammal_data.Deserialize();
						tb_list.DataContext = Mammals.ToList();
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls = await arti_data.Deserialize();
						tb_list.DataContext = Artiodactyls.ToList();
					}
					break;
				case AnimalType.Bird:
					{
						Birds = await bird_data.Deserialize();
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
						animal_data.objects = Animals;
						animal_data.XmlSerialize();
						tb_list.DataContext = Animals.ToList();
					}
					break;
				case AnimalType.Mammal:
					{
						Mammals = new List<Mammal>();
						mammal_data.objects = Mammals;
						mammal_data.XmlSerialize();
						tb_list.DataContext = Mammals.ToList();
					}
					break;
				case AnimalType.Anti:
					{
						Artiodactyls = new List<Artiodactyls>();
						arti_data.objects = Artiodactyls;
						arti_data.XmlSerialize();
						tb_list.DataContext = Artiodactyls.ToList();
					}
					break;
				case AnimalType.Bird:
					{
						Birds = new List<Bird>();
						bird_data.objects = Birds;
						bird_data.XmlSerialize();
						tb_list.DataContext = Birds.ToList();
					}
					break;
				default:
					break;
			}
		}
	}
}
