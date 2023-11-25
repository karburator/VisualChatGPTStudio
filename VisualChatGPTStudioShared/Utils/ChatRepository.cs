﻿using Newtonsoft.Json;
using System.IO;
    /// <summary>
    /// Repository class for managing the Turbo Chats.
    /// </summary>
    public static class ChatRepository
        #region Constantes
        private const string PARAMETER_ID = "@PARAMETER_ID";

        #endregion Constantes
        #region Properties
        private static SQLiteConnection connection;

        #endregion Properties
        #region Methods

        /// <summary>
        /// Creates a database file for VisualChatGptStudio if it does not already exist and opens a connection to it.
        /// </summary>
        public static void CreateDataBase()
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.EXTENSION_NAME);

                filePath = Path.Combine(filePath, "VisualChatGptStudio.db");

                if (!File.Exists(filePath))
                {
                    StreamWriter file = new(filePath, true, Encoding.Default);

                    file.Dispose();
                }

                connection = new SQLiteConnection($"Data Source={filePath}");

                connection.Open();

                CreateTableChats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constants.EXTENSION_NAME, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Creates a table named CHATS in the SQLite database.
        /// </summary>
        private static void CreateTableChats()

        /// <summary>
        /// Retrieves a list of ChatEntity objects from the database.
        /// </summary>
        /// <returns>
        /// A list of ChatEntity objects containing the ID, Name, and Date properties.
        /// </returns>
        public static List<ChatEntity> GetChats()

        /// <summary>
        /// Retrieves a list of messages from the database for a given chat ID.
        /// </summary>
        /// <param name="chatId">The ID of the chat.</param>
        /// <returns>A list of MessageEntity objects representing the messages.</returns>
        public static List<MessageEntity> GetMessages(string chatId)

        /// <summary>
        /// Adds a chat entity to the database.
        /// </summary>
        /// <param name="chat">The chat entity to add.</param>
        public static void AddChat(ChatEntity chat)

        /// <summary>
        /// Updates the chat entity in the database with the provided information.
        /// </summary>
        /// <param name="chat">The chat entity to be updated.</param>
        public static void UpdateChat(ChatEntity chat)

        /// <summary>
        /// Updates the name of the chat entity in the database based on the provided ID.
        /// </summary>
        /// <param name="chatId">The ID of the chat to be updated.</param>
        /// <param name="newName">The new name for the chat.</param>
        public static void UpdateChatName(string chatId, string newName)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = $"UPDATE CHATS SET NAME = {PARAMETER_NAME} WHERE ID = {PARAMETER_ID}";

                command.Parameters.AddWithValue(PARAMETER_NAME, newName);
                command.Parameters.AddWithValue(PARAMETER_ID, chatId);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes the chat entity from the database based on the provided ID.
        /// </summary>
        /// <param name="chatId">The ID of the chat to be deleted.</param>
        public static void DeleteChat(string chatId)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = $"DELETE FROM CHATS WHERE ID = {PARAMETER_ID}";

                command.Parameters.AddWithValue(PARAMETER_ID, chatId);

                command.ExecuteNonQuery();
            }
        }

        #endregion Methods
    }