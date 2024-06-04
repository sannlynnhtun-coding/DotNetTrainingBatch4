const tblBlog = "blogs";
let blogId = null;

getBlogTable();
// testConfirmMessage();
// testConfirmMessage2();

function testConfirmMessage() {
    let confirmMessage = new Promise(function (success, error) {
        // "Producing Code" (May take some time)
        const result = confirm('Are you sure want to delete?');
        if (result) {
            success(); // when successful
        } else {
            error();  // when error
        }
    });

    // "Consuming Code" (Must wait for a fulfilled Promise)
    confirmMessage.then(
        function (value) {
            /* code if successful */
            successMessage("Success");
        },
        function (error) {
            /* code if some error */
            errorMessage("Error");
        }
    );
}

function testConfirmMessage2() {
    let confirmMessage = new Promise(function (success, error) {
        // "Producing Code" (May take some time)

        Swal.fire({
            title: "Confirm",
            text: "Are you sure want to delete?",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Yes"
        }).then((result) => {
            if (result.isConfirmed) {
                success(); // when successful
            } else {
                error();  // when error
            }
        });
    });

    // "Consuming Code" (Must wait for a fulfilled Promise)
    confirmMessage.then(
        function (value) {
            /* code if successful */
            successMessage("Success");
        },
        function (error) {
            /* code if some error */
            errorMessage("Error");
        }
    );
}

// readBlog();
// createBlog();
// updateBlog("fd71a8f8-8a56-47ed-846f-5bf1bfb4bc2e", 'dfasdfasfd', 'dfasdf', 'dfayrwg');
// deleteBlog("02b5e93f-b4e0-45e5-a490-b1c45e4a6022");

function readBlog() {
    let lst = getBlogs();
    console.log(lst);
}

function editBlog(id) {
    let lst = getBlogs();

    const items = lst.filter(x => x.id === id);
    console.log(items);

    console.log(items.length);

    if (items.length == 0) {
        console.log("no data found.");
        errorMessage("no data found.");
        return;
    }

    // return items[0];

    let item = items[0];

    blogId = item.id;
    $('#txtTitle').val(item.title);
    $('#txtAuthor').val(item.author);
    $('#txtContent').val(item.content);
    $('#txtTitle').focus();
}

function createBlog(title, author, content) {
    let lst = getBlogs();

    const requestModel = {
        id: uuidv4(),
        title: title,
        author: author,
        content: content
    };

    lst.push(requestModel);

    const jsonBlog = JSON.stringify(lst);
    localStorage.setItem(tblBlog, jsonBlog);
    // localStorage.setItem("blogs", requestModel);

    successMessage("Saving Successful.");
    clearControls();
}

function updateBlog(id, title, author, content) {
    let lst = getBlogs();

    const items = lst.filter(x => x.id === id);
    console.log(items);

    console.log(items.length);

    if (items.length == 0) {
        console.log("no data found.");
        errorMessage("no data found.");
        return;
    }

    const item = items[0];
    item.title = title;
    item.author = author;
    item.content = content;

    const index = lst.findIndex(x => x.id === id);
    lst[index] = item;

    const jsonBlog = JSON.stringify(lst);
    localStorage.setItem(tblBlog, jsonBlog);

    successMessage('Updating Successful.');
}

function deleteBlog2(id) {
    let result = confirm("are you sure want to delete?");
    if (!result) return;

    let lst = getBlogs();

    const items = lst.filter(x => x.id === id);
    if (items.length == 0) {
        console.log("no data found.");
        return;
    }

    lst = lst.filter(x => x.id !== id);
    const jsonBlog = JSON.stringify(lst);
    localStorage.setItem(tblBlog, jsonBlog);

    successMessage("Deleting Successful.");

    getBlogTable();
}

function deleteBlog3(id) {
    Swal.fire({
        title: "Confirm",
        text: "Are you sure want to delete?",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: "Yes"
    }).then((result) => {
        if (!result.isConfirmed) return;

        let lst = getBlogs();

        const items = lst.filter(x => x.id === id);
        if (items.length == 0) {
            console.log("no data found.");
            return;
        }

        lst = lst.filter(x => x.id !== id);
        const jsonBlog = JSON.stringify(lst);
        localStorage.setItem(tblBlog, jsonBlog);

        successMessage("Deleting Successful.");

        getBlogTable();
    });
}

function deleteBlog(id) {
    confirmMessage("Are you sure want to delete?").then(
        function (value) {
            let lst = getBlogs();

            const items = lst.filter(x => x.id === id);
            if (items.length == 0) {
                console.log("no data found.");
                return;
            }

            lst = lst.filter(x => x.id !== id);
            const jsonBlog = JSON.stringify(lst);
            localStorage.setItem(tblBlog, jsonBlog);

            successMessage("Deleting Successful.");

            getBlogTable();
        }
    );
}

function getBlogs() {
    const blogs = localStorage.getItem(tblBlog);
    console.log(blogs);

    let lst = [];
    if (blogs !== null) {
        lst = JSON.parse(blogs);
    }
    return lst;
}

$('#btnSave').click(function () {
    const title = $('#txtTitle').val();
    const author = $('#txtAuthor').val();
    const content = $('#txtContent').val();

    if (blogId === null) {
        createBlog(title, author, content);
    }
    else {
        updateBlog(blogId, title, author, content);
        blogId = null;
    }

    getBlogTable();
})

function clearControls() {
    $('#txtTitle').val('');
    $('#txtAuthor').val('');
    $('#txtContent').val('');
    $('#txtTitle').focus();
}

function getBlogTable() {
    const lst = getBlogs();
    let count = 0;
    let htmlRows = '';
    lst.forEach(item => {
        const htmlRow = `
        <tr>
            <td>
                <button type="button" class="btn btn-warning" data-id="${item.id}" onclick="editBlog('${item.id}')">Edit</button>
                <button type="button" class="btn btn-danger" data-blog-id="${item.id}" onclick="deleteBlog('${item.id}')">Delete</button>
            </td>
            <td>${++count}</td>
            <td>${item.title}</td>
            <td>${item.author}</td>
            <td>${item.content}</td>
        </tr>
        `;
        htmlRows += htmlRow;
    });

    $('#tbody').html(htmlRows);
}