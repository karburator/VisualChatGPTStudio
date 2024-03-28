﻿using Community.VisualStudio.Toolkit;
using JeffPires.VisualChatGPTStudio.Options;
using System;
using UserControl = System.Windows.Controls.UserControl;
    /// Represents a control for code review in a terminal window.
    /// </summary>
    public partial class TerminalWindowCodeReviewControl : UserControl
        /// Initializes a new instance of the TerminalWindowCodeReviewControl class.
        /// This constructor ensures the MdXaml library is loaded successfully by creating an instance of MarkdownScrollViewer.
        /// </summary>
        /// Handles the click event of the code review button. It initiates the process of fetching current Git changes.
        /// </summary>
        /// Handles the click event of the cancel button. It disables the buttons and signals a cancellation request to the CancellationTokenSource.
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        /// Handles the Click event of the btnExpandAll button. It expands all items in the CodeReviews collection.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnExpandAll_Click(object sender, RoutedEventArgs e)
        /// Handles the Click event of the btnCollapseAll button. It collapses all items in the CodeReviews collection by setting their IsExpanded property to false.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void btnCollapseAll_Click(object sender, RoutedEventArgs e)
        /// Handles the click event on the diff view button, retrieves the associated file name from the button's tag,
        /// finds the corresponding code review item, and displays the difference between the original and altered code.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Event arguments.</param>
        private async void btnDiffView_Click(object sender, RoutedEventArgs e)
        /// Handles the RequestNavigate event of a Hyperlink control, opening the file specified by the URI and marking the event as handled.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RequestNavigateEventArgs"/> instance containing the event data.</param>
        private async void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        /// Handles the mouse wheel event on a text box to scroll up or down.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A MouseWheelEventArgs that contains the event data.</param>
        private void txtCodeReview_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        /// Initializes control with specified options and package.
        /// </summary>
        /// <param name="options">The general options for the control.</param>
        /// Enables or disables specific buttons and toggles visibility of certain UI elements based on the reviewing state.
        /// </summary>
        /// <param name="reviewing">Indicates whether the reviewing mode is active.</param>
        private void EnableDisableButtons(bool reviewing)
        /// Performs a code review on a given patch entry change asynchronously, utilizing an AI-based chat service for generating the code review comments and separating the original and altered code segments.
        /// </summary>
        /// <param name="change">The patch entry changes containing the code to be reviewed.</param>
        /// <returns>A task that represents the asynchronous operation, resulting in a CodeReviewItem containing the review details.</returns>
        private async Task<CodeReviewItem> DoCodeReview(PatchEntryChanges change)

        #endregion Methods     