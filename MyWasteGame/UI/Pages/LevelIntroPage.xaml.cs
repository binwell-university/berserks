using System;
namespace MyWasteGame.UI.Pages {
	public partial class LevelIntroPage : BasePage {
		public LevelIntroPage() {
			InitializeComponent();
		}
		public async void GoToLevelClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new LevelPage());
		}
		public async void ViewReferenceClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new RecyclableReferencePage());
		}
		
	}
}