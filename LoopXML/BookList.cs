using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace LoopXML
{
    public partial class frmBookList : Form
    {
        List<Book> BookList = new List<Book>();
        Queue<Book> bookQueue = new Queue<Book>();
        public frmBookList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookQueue.Count > 0)
            {
                var book = bookQueue.Dequeue();
                textBox1.Text = book.title;
                textBox2.Text = book.price.ToString();
                label3.Text = "Books in list: " + bookQueue.Count.ToString();

            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                button1.Enabled = false;
                //MessageBox.Show("That's all folks!");
            }
        }

        private void frmBookList_Load(object sender, EventArgs e)
        {
            
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(@"C:\Users\Kyle\Documents\Visual Studio 2013\Projects\books.xml");
            XmlNodeList XmlDocNodes = XmlDoc.DocumentElement.SelectNodes("/catalog/book");
            
            foreach (XmlNode node in XmlDocNodes)
            {
                Book obj = new Book(
                    node.Attributes["id"].Value,
                    node["author"].InnerText,
                    node["title"].InnerText,
                    node["genre"].InnerText,
                    Convert.ToDecimal(node["price"].InnerText),
                    Convert.ToDateTime(node["publish_date"].InnerText),
                    node["description"].InnerText
                    );
                BookList.Add(obj);
            }
            loadQue();
        }

        private void loadQue()
        {
            bookQueue.Clear();
            foreach (Book b in BookList)
            {
                bookQueue.Enqueue(b);
            }

            label3.Text = "Books in list: " + BookList.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadQue();
            textBox1.Clear();
            textBox2.Clear();
            button1.Enabled = true;
        }
    }
}