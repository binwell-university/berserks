namespace MyWasteGame
{
	public enum AppPages {
		Start,
		Level,
		Mistake,
		GameIntro,
		LevelIntro,
		PlasticReference,
		RecyclableRefence,
		UnrecyclableRefence,
	}

	public enum NavigationMode {
		Normal,
		Modal,
		Root,
		Custom
	}

	public enum PageState {
		Clean,
		Loading,
		Normal,
		NoData,
		Error,
		NoInternet
	}
}

