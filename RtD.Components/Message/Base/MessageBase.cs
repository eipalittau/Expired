namespace RtD.Components {
    public abstract class MessageBase : IDisposable {
        #region Events
        public event EventHandler<EventArgs.InternalMessageEventArgs>? Message;
        #endregion

        #region Properties / Felder
        private bool mDisposedValue;
        #endregion

        #region Methoden
        protected void RaiseMessage(EventArgs.InternalMessageEventArgs[] aMessages) {
            if (aMessages != null && aMessages.Length > 0) {
                foreach (EventArgs.InternalMessageEventArgs aMessage in aMessages) {
                    Message?.Invoke(this, aMessage);
                }
            }
        }

        #region Debug
        protected void RaiseDebug(long aID) {
            Message?.Invoke(this, new EventArgs.InternalMessageEventArgs(aID, Enumerations.PriorityEnum.Debug));
        }

        protected void RaiseDebug(long aID, params string[] aParams) {
            Message?.Invoke(this, new EventArgs.InternalMessageEventArgs(aID, Enumerations.PriorityEnum.Debug, aParams));
        }
        #endregion

        #region Information
        protected void RaiseInformation(long aID) {
            Message?.Invoke(this, new EventArgs.InternalMessageEventArgs(aID, Enumerations.PriorityEnum.Information));
        }

        protected void RaiseInformation(long aID, params string[] aParams) {
            Message?.Invoke(this, new EventArgs.InternalMessageEventArgs(aID, Enumerations.PriorityEnum.Information, aParams));
        }
        #endregion

        #region Warning
        protected void RaiseWarning(long aID) {
            Message?.Invoke(this, new EventArgs.InternalMessageEventArgs(aID, Enumerations.PriorityEnum.Warning));
        }

        protected void RaiseWarning(long aID, params string[] aParams) {
            Message?.Invoke(this, new EventArgs.InternalMessageEventArgs(aID, Enumerations.PriorityEnum.Warning, aParams));
        }
        #endregion


        #region Dispose
        protected virtual void Dispose(bool aDisposing) {
            if (!mDisposedValue) {
                if (aDisposing) {
                    Message = null;
                }

                mDisposedValue = true;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
        #endregion
    }
}