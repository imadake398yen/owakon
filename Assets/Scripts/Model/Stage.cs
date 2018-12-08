namespace Model {

	[System.Serializable]
	public class Stage {

		private static Stage _current;
		public static void Init () { _current = new Stage(); }

		private Const.StageState _state = Const.StageState.Create;
		public static Const.StageState State { get { return _current._state; } }
		public static void ChangeState (Const.StageState state) { _current._state = state; }

	}
}