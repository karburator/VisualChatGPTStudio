﻿using Community.VisualStudio.Toolkit;
    /// <summary>
    /// Represents a class that provides a dialog page for displaying commands options.
    /// </summary>
    [ComVisible(true)]
    public class OptionCommands : UIElementDialogPage

        /// <summary>
        /// Gets the child UIElement for the control.
        /// </summary>
        /// <returns>
        /// The child UIElement, which is an instance of OptionCommandsWindow.
        /// </returns>
        protected override UIElement Child

        /// <summary>
        /// Initializes a new instance of the OptionCommands class.
        /// </summary>
        public OptionCommands()

        /// <summary>
        /// Updates the commands list and saves it to a config file.
        /// </summary>
        /// <param name="commands">The updated list of commands.</param>
        private void Window_EventUpdateCommands(List<Commands> commands)

        /// <summary>
        /// Retrieves the command associated with the specified command type.
        /// </summary>
        /// <param name="commandType">The type of command to retrieve.</param>
        /// <returns>The command as a string.</returns>
        public async Task<string> GetCommandAsync(CommandsType commandType)
            {
                prompt = commands.First(c => string.IsNullOrWhiteSpace(c.ProjectName)).GetType().GetProperty(commandType.ToString()).GetValue(command).ToString();
            }

        /// <summary>
        /// Creates default commands for the application.
        /// </summary>
        private void CreateDefaultCommands()

    /// <summary>
    /// Enum representing different types of commands.
    /// </summary>
    public enum CommandsType