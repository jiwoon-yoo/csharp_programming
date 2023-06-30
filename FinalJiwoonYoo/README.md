Exam Instructions:
1. Make a WPF App (.NET Framework) in Visual Studio and name it as 
FinalFirstnameLastname.
2. The app should be able to display and add products from the Northwind database.
3. Download the Northwind-Sample-Database-for-LocalDB.sql file and use the SQL 
script it contains to create and populate the database.
a. Download from SLATE → Content → Module 6 - Database Programming →
Sample Databases.
b. When creating a new database, it must be named Northwind, otherwise, the 
script will not run properly.
c. Use LocalDB as database source, unless you’ve got written permission from 
your professor to use a different data source such as SQL Server or MDF file.
4. In the WPF App, add Entity Framework.
5. Use DB First approach to generate the entities.
6. The application should have two windows: Home | Add Product
1. This window has:
a. Buttons: Four buttons to get all products, clear fields, search product and add 
new product.
b. ComboBox: To display list of categories.
c. TextBox: To enter the product name to search for it.
d. DataGrid: To display the fetched data of products from the Products table.
2. When the user clicks the “Get All Products” button, fetch all the products data from 
the Products table and display it in the DataGrid. Also, populate the categories 
ComboBox with categories.
3. The “Clear Data” button clears all the data from the window, that is, it clears the 
DataGrid, the ComboBox and any text from the TextBox. 
4. The user can get all the products from a selected category. When the user selects a 
category name from the categories ComboBox, fetch and display all the products that 
belong to the selected category in the DataGrid. 
5. The user can also search for a product by name. Fetch and display all the products in 
the DataGrid that match the name entered by the user.
a. Partial name matches should also fetch the products.
6. On clicking the “Add New Product” button, a new window should be displayed which 
can add a new product to the Products table.
a. Display the Add window as a dialog box. Users should not be allowed to go back 
to the Home window as long as the Add window is open.
1. This window has:
a. Two TextBoxes: To enter the product name and price.
b. ComboBox: To display the list of categories.
c. Buttons: To add the above information to the database and to close the window. 
2. On the initial window load, the categories ComboBox is filled with category names. 
3. The user can type the name of the product and its price in the textboxes.
4. Select the category from the category ComboBox.
5. Then, clicking the “Add Product” button adds the information to the Products table.





시험 지침:

Visual Studio에서 .NET Framework를 사용하여 WPF 앱을 만들고 이름을 FinalFirstnameLastname으로 지정하세요.
앱은 Northwind 데이터베이스의 제품을 표시하고 추가할 수 있어야 합니다.
Northwind-Sample-Database-for-LocalDB.sql 파일을 다운로드하고 해당 파일에 포함된 SQL 스크립트를 사용하여 데이터베이스를 생성하고 채워 넣으세요.
a. SLATE → 콘텐츠 → 모듈 6 - 데이터베이스 프로그래밍 → 샘플 데이터베이스에서 다운로드하세요.
b. 새로운 데이터베이스를 만들 때 이름을 Northwind로 지정해야 스크립트가 올바르게 실행됩니다.
c. 다른 데이터 소스(예: SQL Server 또는 MDF 파일)를 사용하려는 경우 교수의 서면 허가가 있어야 합니다.
WPF 앱에 Entity Framework를 추가하세요.
DB First 접근 방식을 사용하여 엔터티를 생성하세요.
애플리케이션에는 두 개의 창이 있어야 합니다: 홈 | 제품 추가
이 창은 다음과 같은 요소를 갖습니다:
a. 버튼: 모든 제품을 가져오기, 필드 지우기, 제품 검색 및 새 제품 추가를 위한 네 개의 버튼.
b. ComboBox: 카테고리 목록을 표시하기 위해.
c. TextBox: 제품 이름을 입력하기 위한 용도.
d. DataGrid: Products 테이블에서 가져온 제품 데이터를 표시하기 위한 용도.
사용자가 "모든 제품 가져오기" 버튼을 클릭하면 Products 테이블에서 모든 제품 데이터를 가져와 DataGrid에 표시하세요. 또한, 카테고리 ComboBox를 카테고리로 채워넣으세요.
"데이터 지우기" 버튼은 창에서 모든 데이터를 지웁니다. 즉, DataGrid, ComboBox 및 TextBox의 텍스트를 모두 지웁니다.
사용자는 선택한 카테고리에서 모든 제품을 가져올 수 있습니다. 사용자가 카테고리 ComboBox에서 카테고리 이름을 선택하면 선택한 카테고리에 속하는 모든 제품을 가져와 DataGrid에 표시하세요.
사용자는 제품을 이름으로 검색할 수도 있습니다. 사용자가 입력한 이름과 일치하는 모든 제품을 DataGrid에 가져와 표시하세요.
a. 부분 이름 일치도 제품을 가져와야 합니다.
"새 제품 추가" 버튼을 클릭하면 Products 테이블에 새 제품을 추가할 수 있는 새 창이 표시되어야 합니다.
a. 추가 창을 대화 상자로 표시하세요. 추가 창이 열려 있는 동안 홈 창으로 돌아갈 수 없도록 해야 합니다.
1. 이 창은 다음과 같은 요소를 갖습니다:
a. 두 개의 TextBox: 제품 이름과 가격을 입력하기 위한 용도.
b. ComboBox: 카테고리 목록을 표시하기 위한 용도.
c. 버튼: 위의 정보를 데이터베이스에 추가하고 창을 닫기 위한 용도.
2. 초기 창 로드 시, 카테고리 ComboBox에 카테고리 이름이 채워져야 합니다.
3. 사용자는 텍스트 상자에 제품 이름과 가격을 입력할 수 있습니다.
4. 카테고리 ComboBox에서 카테고리를 선택하세요.
5. 그런 다음, "제품 추가" 버튼을 클릭하여 정보를 Products 테이블에 추가하세요.
