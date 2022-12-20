FileSystemComponent mainComponent = new FileSystemComponent("main");
FileSystemComponent component1 = new FileSystemComponent("sussy");
FileSystemComponent component2 = new FileSystemComponent("baka");
FileSystemComponent component3 = new FileSystemComponent("hello");
FileSystemComponent component21 = new FileSystemComponent("world");
FileSystemComponent component22 = new FileSystemComponent("and");
FileSystemComponent component11 = new FileSystemComponent("me");
FileSystemComponent component111 = new FileSystemComponent("folder");
FileSystemComponent component211 = new FileSystemComponent("something");
FileSystemComponent component212 = new FileSystemComponent("testing");


mainComponent.Add(component1);
mainComponent.Add(component2);
mainComponent.Add(component3);

component1.Add(component11);

component2.Add(component21);
component2.Add(component22);

component11.Add(component111);

component21.Add(component211);
component21.Add(component212);

mainComponent.DisplayInfo();