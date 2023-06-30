Mid-Term Project Instructions:
Create a WPF Collections app:
• The App will read, insert, update, and delete for each item of data. Use LINQ to select 
your data. Your app should come preloaded with 5 pieces of data for each collection.
• Start a WPF by loading a home window with multiple buttons, each button should open 
new window with its own collection (Use ListBox to store collection data) to display 
each collection’s data. Allow textboxes to insert/update/delete data for that collection.
• Show a message box with an error message for incorrect type (Provide adequate 
validations).
Create a menu bar (top menu, or “file” menu) in the home window with:
• File (New, Save, Quit – quit will be the only working button to actually quit the 
application).
• Edit (Insert, Update, Delete – all will work to do that operation on the window that is 
opened on the item selected in the ListBox).
• Show a message box with an error message if nothing is selected or there are empty text 
boxes.
• Help (launches new Window that serves as an about page).
Note:
• All windows should not be the default grey colour but instead should be dressed up.
• You should have a message box asking the user to confirm quitting the application.
• You should have a message box asking the user to confirm if they wish to delete or 
update the data for all collections.
Object information for a collection:
1. Create a C# class called Person containing
• ID (int)
• Name (string)
• Address (string)
• Email (string)
• Age (int)
• Birthday (string)
Create a List to store a collection of these objects.
2. Create a C# class called SportsTeam containing
• ID (int)
• personID (int – should be id of person from object collection 1, i.e. Think 
of it like a “foreign key” in databases) (Hint: Inheritance)
• Sports team (string)
• City (string)
Create a List to store a collection of these objects.
3. Create a C# class called Personality containing
• ID (int)
• personID (int – should be id of person from object collection 1, i.e. Think 
of it like a “foreign key” in databases) (Hint: Inheritance)
• Shoe size (int)
• Favourite movie (string)
• Favourite actor (string)
Create a List to store a collection of these objects.
4. Create a C# class called Education containing
• ID (int)
• personID (int – should be id of person from object collection 1, i.e. Think 
of it like a “foreign key” in databases) (Hint: Inheritance)
• Course Name (string)
• Course grade (double)
• Comments (string)
Create a List to store a collection of these objects.




중간고사 프로젝트 지침:
WPF Collections 앱을 만드세요:
• 앱은 각 데이터 항목에 대한 읽기, 삽입, 업데이트, 삭제 기능을 갖추어야 합니다. LINQ를 사용하여 데이터를 선택하세요. 각 컬렉션에는 미리 5개의 데이터 항목이 로드되어 있어야 합니다.
• 다수의 버튼을 포함하는 홈 창을 로드하여 각 버튼이 자체 컬렉션을 열 수 있도록 하세요(각 컬렉션 데이터를 저장하기 위해 ListBox를 사용). 해당 컬렉션의 데이터를 표시하기 위해 텍스트 상자를 허용하세요. 데이터 삽입/업데이트/삭제를 위한 텍스트 상자를 허용하세요.
• 잘못된 유형에 대한 오류 메시지를 표시하세요(적절한 유효성 검사를 제공하세요).
홈 창에 메뉴 바(File(새로 만들기, 저장, 종료 - 종료는 앱을 실제로 종료하는 유일한 작동 버튼입니다), Edit(삽입, 업데이트, 삭제 - ListBox에서 선택된 항목에 대해 해당 작업을 수행합니다), 도움말(새로운 창을 열어 소개 페이지로 사용)을 만드세요.
참고:
• 모든 창은 기본 회색 색상이 아니라 꾸며진 스타일을 가져야 합니다.
• 사용자에게 응용 프로그램을 종료하시겠습니까? 라는 메시지 상자를 표시하세요.
• 사용자가 데이터를 모든 컬렉션에 대해 삭제하거나 업데이트하시겠습니까? 라는 메시지 상자를 표시하세요.
컬렉션에 대한 객체 정보:

Person이라는 C# 클래스를 만드세요.
• ID(int)
• Name(string)
• Address(string)
• Email(string)
• Age(int)
• Birthday(string)
이러한 객체의 컬렉션을 저장하기 위해 List를 만드세요.
SportsTeam이라는 C# 클래스를 만드세요.
• ID(int)
• personID(int - 객체 컬렉션 1의 사람 ID여야 합니다. 데이터베이스에서 "외래 키"처럼 생각하세요) (힌트: 상속)
• Sports team(string)
• City(string)
이러한 객체의 컬렉션을 저장하기 위해 List를 만드세요.
Personality라는 C# 클래스를 만드세요.
• ID(int)
• personID(int - 객체 컬렉션 1의 사람 ID여야 합니다. 데이터베이스에서 "외래 키"처럼 생각하세요) (힌트: 상속)
• Shoe size(int)
• Favourite movie(string)
• Favourite actor(string)
이러한 객체의 컬렉션을 저장하기 위해 List를 만드세요.
Education이라는 C# 클래스를 만드세요.
• ID(int)
• personID(int - 객체 컬렉션 1의 사람 ID여야 합니다. 데이터베이스에서 "외래 키"처럼 생각하세요) (힌트: 상속)
• Course Name(string)
• Course grade(double)
• Comments(string)
이러한 객체의 컬렉션을 저장하기 위해 List를 만드세요.
