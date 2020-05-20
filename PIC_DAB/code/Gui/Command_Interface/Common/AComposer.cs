namespace CmdInterface.common
{
    public class AComposer
    {
        private IView_FormMain _iView;

        public AComposer(IView_FormMain i_view)
        {
            _iView = i_view;
        }

        protected void CmdString(string cmd)
        {
            _iView.ShowCommand(cmd);
        }
    }
}
