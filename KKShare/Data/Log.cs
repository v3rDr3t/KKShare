using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Data
{
    public enum Severity
    {
        Debug = 0,
        Info = 1,
        Warning = 2,
        Error = 3
    };

    public class Log : Observable
    {
        private static readonly Log logInstance = new Log();
        private List<LogMessage> log;

        static Log(){ }

        /// <summary>
        /// Default constructor.
        /// </summary>
        private Log()
        {
            log = new List<LogMessage>();
        }

        /// <summary>
        /// Adds the given log message parameters as new log message.
        /// </summary>
        /// <param name="severity">The log message severity.</param>
        /// <param name="description">The log message description.</param>
        public void AddMessage(Severity severity, string description)
        {
            log.Add(new LogMessage(severity, description));
            Notify();
        }

        /// <summary>
        /// Creates and/or gets the log instance.
        /// </summary>
        public static Log Instance
        {
            get { return logInstance; }
        }

        public List<LogMessage> List
        {
            get { return log; }
        }
    }

    public class LogMessage
    {
        private DateTime dateTime;
        private Severity severity;
        private string description;

        /// <summary>
        /// Constructs an instance of <see cref="LogMessage"/>.
        /// </summary>
        /// <param name="severity">The log message severity.</param>
        /// <param name="description">The log message description.</param>
        public LogMessage(Severity severity, string description)
        {
            this.dateTime = DateTime.Now;
            this.severity = severity;
            this.description = description;
        }

        #region Field Getters
        public string Time
        {
            get { return dateTime.ToString(Constants.LOG_DATETIME_FORMAT); }
        }

        public string Severity
        {
            get { return severity.ToString(); }
        }

        public string Description
        {
            get { return description; }
        }
        #endregion
    }
}
