
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table mainTable;
	
	private global::Gtk.Button vboxBorderWidthBAfterShowButton;
	
	private global::Gtk.Button vboxBorderWidthBeforeShowButton;
	
	private global::Gtk.Label vboxBorderWidthBeforeShowLabel;
	
	private global::Gtk.Label vboxBorderWidthBeforeShowLabel1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.mainTable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
		this.mainTable.Name = "mainTable";
		this.mainTable.RowSpacing = ((uint)(6));
		this.mainTable.ColumnSpacing = ((uint)(6));
		// Container child mainTable.Gtk.Table+TableChild
		this.vboxBorderWidthBAfterShowButton = new global::Gtk.Button ();
		this.vboxBorderWidthBAfterShowButton.CanFocus = true;
		this.vboxBorderWidthBAfterShowButton.Name = "vboxBorderWidthBAfterShowButton";
		this.vboxBorderWidthBAfterShowButton.UseUnderline = true;
		this.vboxBorderWidthBAfterShowButton.Label = global::Mono.Unix.Catalog.GetString ("Show Dialog");
		this.mainTable.Add (this.vboxBorderWidthBAfterShowButton);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.mainTable [this.vboxBorderWidthBAfterShowButton]));
		w1.TopAttach = ((uint)(1));
		w1.BottomAttach = ((uint)(2));
		w1.LeftAttach = ((uint)(1));
		w1.RightAttach = ((uint)(2));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child mainTable.Gtk.Table+TableChild
		this.vboxBorderWidthBeforeShowButton = new global::Gtk.Button ();
		this.vboxBorderWidthBeforeShowButton.CanFocus = true;
		this.vboxBorderWidthBeforeShowButton.Name = "vboxBorderWidthBeforeShowButton";
		this.vboxBorderWidthBeforeShowButton.UseUnderline = true;
		this.vboxBorderWidthBeforeShowButton.Label = global::Mono.Unix.Catalog.GetString ("Show Dialog");
		this.mainTable.Add (this.vboxBorderWidthBeforeShowButton);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.mainTable [this.vboxBorderWidthBeforeShowButton]));
		w2.LeftAttach = ((uint)(1));
		w2.RightAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child mainTable.Gtk.Table+TableChild
		this.vboxBorderWidthBeforeShowLabel = new global::Gtk.Label ();
		this.vboxBorderWidthBeforeShowLabel.Name = "vboxBorderWidthBeforeShowLabel";
		this.vboxBorderWidthBeforeShowLabel.Xalign = 0F;
		this.vboxBorderWidthBeforeShowLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("VBox.BorderWidth = 0 before Show");
		this.mainTable.Add (this.vboxBorderWidthBeforeShowLabel);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.mainTable [this.vboxBorderWidthBeforeShowLabel]));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child mainTable.Gtk.Table+TableChild
		this.vboxBorderWidthBeforeShowLabel1 = new global::Gtk.Label ();
		this.vboxBorderWidthBeforeShowLabel1.Name = "vboxBorderWidthBeforeShowLabel1";
		this.vboxBorderWidthBeforeShowLabel1.Xalign = 0F;
		this.vboxBorderWidthBeforeShowLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("VBox.BorderWidth = 0 after Show");
		this.mainTable.Add (this.vboxBorderWidthBeforeShowLabel1);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.mainTable [this.vboxBorderWidthBeforeShowLabel1]));
		w4.TopAttach = ((uint)(1));
		w4.BottomAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add (this.mainTable);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.vboxBorderWidthBeforeShowButton.Clicked += new global::System.EventHandler (this.OnVboxBorderWidthBeforeShowButtonClicked);
		this.vboxBorderWidthBAfterShowButton.Clicked += new global::System.EventHandler (this.OnVboxBorderWidthAfterShowButtonClicked);
	}
}
