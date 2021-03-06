                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                namespace UnityEditor.TestTools.TestRunner
{
    internal class DelayedCallback
    {
        private System.Action m_Callback;
        private double m_CallbackTime;
        private double m_Delay;

        public DelayedCallback(System.Action function, double timeFromNow)
        {
            m_Callback = function;
            m_CallbackTime = EditorApplication.timeSinceStartup + timeFromNow;
            m_Delay = timeFromNow;
            EditorApplication.update += Update;
        }

        public void Clear()
        {
            EditorApplication.update -= Update;
            m_CallbackTime = 0.0;
            m_Callback = null;
        }

        private void Update()
        {
            if (E