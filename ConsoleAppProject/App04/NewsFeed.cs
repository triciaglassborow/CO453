using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    public class NewsFeed
    {
        public readonly List<MessagePost> messages;
        public readonly List<PhotoPost> photos;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            messages = new List<MessagePost>();
            photos = new List<PhotoPost>();
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            messages.Add(message);
        }

        public void DeletePost(int index)
        {
            if (index < messages.Count)
            {
                messages.RemoveAt(index);
            }
            else
            {
                photos.RemoveAt(index - messages.Count);
            }
        }

        public void LikePost(int index)
        {
            if (index < messages.Count)
            {
                FindMessageWithIndex(index).Like();
            }
            else
            {
                int temp = index - messages.Count;
                FindPhotoWithIndex(temp).Like();
            }
        }

        public void UnlikePost(int index)
        {
            if (index < messages.Count)
            {
                FindMessageWithIndex(index).Unlike();
            }
            else
            {
                int temp = index - messages.Count;
                FindPhotoWithIndex(temp).Unlike();
            }
        }

        public void CommentPost(int index, string message)
        {
            if (index < messages.Count)
            {
                FindMessageWithIndex(index).AddComment(message);
            }
            else
            {
                int temp = index - messages.Count;
                FindPhotoWithIndex(temp).AddComment(message);
            }
        }
        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            photos.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            int index = 0;
            // display all text posts
            foreach (MessagePost message in messages)
            {
                Console.WriteLine(index);
                message.Display();
                Console.WriteLine();   // empty line between posts
                index++;
            }

            // display all photos
            foreach (PhotoPost photo in photos)
            {
                Console.WriteLine(index);
                photo.Display();
                Console.WriteLine();   // empty line between posts
                index++;
            }
        }

        public MessagePost FindMessageWithIndex(int index)
        {
            int i = 0;
            foreach (MessagePost message in messages)
            {
                if (i == index) return message;
                i++;
            }
            return null;
        }

        public PhotoPost FindPhotoWithIndex(int index)
        {
            int i = 0;
            foreach (PhotoPost photo in photos)
            {
                if (i == index) return photo;
                i++;
            }
            return null;
        }
    }

}
