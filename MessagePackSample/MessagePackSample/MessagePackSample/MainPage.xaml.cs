using System;
using System.Collections.Generic;
using MessagePack;
using Xamarin.Forms;
using MessagePack.Resolvers;

namespace MessagePackSample
{
    [MessagePackObject]
    public class CustomObject
    {
        [Key(0)]
        public string Item1 { get; set; }

        [Key(1)]
        public DateTime Item2 { get;set; }

        public override string ToString()
        {
            return $"[{Item1} - {Item2.ToShortDateString()}]";
        }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
            MessagePackSerializerOptions generatedResolverOptions =
            MessagePackSerializerOptions.Standard
                .WithResolver(
                    CompositeResolver.Create(
                        GeneratedResolver.Instance,
                        StandardResolver.Instance
                    ));

            var customObjects = new List<CustomObject>
            {
                new CustomObject() {Item1 = "Yesterday", Item2 = DateTime.Today.AddDays(-1)},
                new CustomObject() {Item1 = "Today", Item2 = DateTime.Today},
                new CustomObject() {Item1 = "Next week", Item2 = DateTime.Today.AddDays(7)}
            };
            MyLabel1.Text = $"{string.Join(", ", customObjects)}";

            var serializedObj = MessagePackSerializer.Serialize(customObjects, generatedResolverOptions);

            try
            {
                var deserializedObj =
                    (IEnumerable<CustomObject>)MessagePackSerializer.Deserialize(typeof(IEnumerable<CustomObject>), serializedObj, generatedResolverOptions);

                MyEntry1.Text = $"{string.Join(", ", customObjects)}";
            }
            catch(Exception ex)
            {
                MyEntry1.Text = $"{ex.Message}{Environment.NewLine}{ex}";
            }
        }
    }
}
