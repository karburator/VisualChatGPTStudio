﻿using OpenAI_API.Chat;
    /// Conversation override class. Necessary to fix the "twice request" bug from the original code. 
    /// </summary>
    public class ConversationOverride : Conversation
        /// Initializes a new instance of the ConversationOverride class with the specified endpoint, model and default chat request arguments.
        /// </summary>
        /// <param name="endpoint">The chat endpoint to use for the conversation.</param>
        /// <param name="model">The model to use for the conversation. Can be null.</param>
        /// <param name="defaultChatRequestArgs">The default chat request arguments to use for the conversation. Can be null.</param>
        public ConversationOverride(ChatEndpoint endpoint, Model model = null, ChatRequest defaultChatRequestArgs = null) : base(endpoint, model, defaultChatRequestArgs)
        /// Sends a request to the chatbot endpoint with the current set of messages and request parameters, and returns the response message content.
        /// </summary>
        /// <returns>
        /// The content of the response message from the chatbot endpoint, or null if an error occurred or no response was received.
        /// </returns>
        public new async Task<string> GetResponseFromChatbotAsync()
        /// Streams the response from the chatbot asynchronously and invokes the provided result handler for each response received.
        /// </summary>
        /// <param name="resultHandler">The action to be invoked for each response received from the chatbot.</param>
        public new async Task StreamResponseFromChatbotAsync(Action<string> resultHandler)
        /// Asynchronously streams the response from the chatbot as an enumerable of strings.
        /// </summary>
        /// <returns>
        /// An asynchronous enumerable of strings representing the response from the chatbot.
        /// </returns>
        public new async IAsyncEnumerable<string> StreamResponseEnumerableFromChatbotAsync()
        /// Truncates the context of the chat messages when the HttpRequestException contains the "context_length_exceeded" code.
        /// </summary>
        /// <param name="ex">The HttpRequestException that was thrown.</param>
        /// <returns>True if the context was truncated, false otherwise.</returns>
        private bool TruncateContextWhenExceeded(HttpRequestException ex)