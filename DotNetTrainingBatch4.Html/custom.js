function uuidv4() {
    return "10000000-1000-4000-8000-100000000000".replace(/[018]/g, c =>
        (+c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> +c / 4).toString(16)
    );
}

function successMessage(message) {
    // alert(message);

    // Swal.fire({
    //     title: "Success!",
    //     text: message,
    //     icon: "success"
    // });

    Notiflix.Report.success(
        'Success!',
        message,
        'Ok',
    );
}

function errorMessage(message) {
    // alert(message);

    // Swal.fire({
    //     title: "Error!",
    //     text: message,
    //     icon: "error"
    // });

    Notiflix.Report.failure(
        'Error!',
        message,
        'Ok',
    );
}

function confirmMessage(message) {
    // let confirmMessageResult = new Promise(function (success, error) {
    //     // "Producing Code" (May take some time)

    //     Swal.fire({
    //         title: "Confirm",
    //         text: message,
    //         icon: "warning",
    //         showCancelButton: true,
    //         confirmButtonText: "Yes"
    //     }).then((result) => {
    //         if (result.isConfirmed) {
    //             success(); // when successful
    //         } else {
    //             error();  // when error
    //         }
    //     });
    // });
    // return confirmMessageResult;

    let confirmMessageResult = new Promise(function (success, error) {
        // "Producing Code" (May take some time)

        Notiflix.Confirm.show(
            'Confirm',
            message,
            'Yes',
            'No',
            function okCb() {
                success(); // when successful
            },
            function cancelCb() {
                error();  // when error
            }
        );
    });
    return confirmMessageResult;
}