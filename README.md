# UserControlStyle
Using Modern Coding Style for Rapid Custom Entity Editing with Asp.NET WebForm.

About me: I'm Daniel. I love improving coding style, trying to make code more readable, reuseable, and understandable. 
This is my little effort to make a good coding style for asp.net web form so that you can do 2-way databinding in a custom control.
Follow this coding style (and re-use the template I provide), you will be able to create a rapid user control for displaying/editing data entity in a few lines of code.

In this project, I'll guide you guy how to build rapid user control to display / edit a data object.

## Modeling
Let's start with the model.
In this section, I'll make a simple Model as a TodoList Item for example. This is the source code

```
  /**
   * Todo Item Model
   **/
  public class TodoItem
  {

      // the Id of the object or whatever
      public int Id { get; set; }

      // Name of this Item
      public string Name { get; set; }

      // Is this Item finished
      public bool IsFinished { get; set; }
  }
```

## Create the User Control.

### Make the Generic Template - Once ^^

Let me explain a little bit. We will make a user control so that we can re-use anywhere in our project. 
This user control is used to display a data item (for example: a TodoItem). 
So the control will contain a property call "Data" as a TodoItem.
Everytime we set the value for "Data", we will bind the display with the Data Property.
Everytime we get the value of "Data", we will collect the data from the View layer back.
To reuse code, we will make a Generic Template like bellow

```
  // DataUser Control class for generics problem
  public class DataUserControl<T>: System.Web.UI.UserControl where T : new()
  {
      // the private item that store data
      private T _data;
      // The Data Item to Display
      public T Data
      {
          // if there is data then return
          // else call CollectData to parse data
          // from view
          get
          {
              if (_data == null)
              {
                  // Collect Data from View
                  _data = CollectData();
              }
              return _data;
          }
          // set the Data and update the view
          set
          {
              _data = value;
              DataBindChildren();
          }
      }

      // Collect Data From Form
      public virtual T CollectData()
      {
          // return the default T
          return default(T);
      }
  }
```

### Create the real User control
Now, it's time to make your own control (TodoItemView for example) to display the TodoListItem. 
This user control will inherit from `DataUserControl<TodoItemView>`, so everything is ready to go.
We just need to custom the view like this:

```
<div class="form-group">
    <asp:CheckBox ID="IsFinishedCheckBox" runat="server" CssClass="checkbox" Checked="<%# Data.IsFinished %>" />
    <asp:Label ID="NameLabel" runat="server" Text="<%# Data.Name %>" />
</div>
```

## Use the control in your page.
Everything is ready. Now we can use in our project, every where:
Add in view:
```
<bt:TodoItemView ID="TodoItemView" runat="server" Data="<%# Item1 %>" />
```
Setting data for it. If isPostBack == false (first time), we will parse data from the database and Bind the data to the View.
Nice coding...

```
  if (!IsPostBack)
  {
      // considering load data from template
      Item1 = new TodoItem
      {
          Name = "Sample Item Without Getting Back",
          IsFinished = false
      };
      // Bind data with view
      DataBind();
  }
```

## Getting the Data Back
If you are making and editing user control, you just need to override the CollectData Method like this:
(So sorry because generic ASP.NET doesn't support two way data binding then we need to code like a farmer like this).
```
  /**
   * Collect Data From View
   **/
  public override TodoItem CollectData()
  {
      var item = new TodoItem();
      item.IsFinished = IsFinishedCheckBox.Checked;
      item.Name = NameLabel.Text;
      return item;
  }
```

Then you can access to Data property of TodoItemView as a TodoItem (you can save it, change it, delete it ^^^).
```
  Item2 = SecondItemView.Data; // this data is get from the input view
  if (Item2.IsFinished)
  {
      MessageLabel.Text = Item2.Name + " is Done";
  }
  else
  {
      MessageLabel.Text = Item2.Name + " is In Progress";
  }
```

## Put in a repeater
See RepeaterDemo for more information.
