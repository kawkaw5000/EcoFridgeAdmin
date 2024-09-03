$(document).ready(function () {
    $('.dropdown-item').on('click', function () {
        var actionType = $(this).text().trim();
        var userId = $(this).data('users-id');

        if (actionType === "Edit") {
            console.log("Selected User ID for Edit: " + userId);

            if (userId) {
                $.ajax({
                    url: '/Home/GetUserById', // URL to get user details
                    type: 'GET',
                    data: { id: userId },
                    success: function (data) {
                        console.log(data); // Check the data returned from the server

                        // Populate the edit form
                        $('#editUserId').val(data.userId);
                        $('#editFirstName').val(data.firstName);
                        $('#editLastName').val(data.lastName);
                        $('#editGender').val(data.gender);
                        $('#editBirthDate').val(data.BirthDate);
                        $('#editStreet').val(data.street);
                        $('#editBaranggay').val(data.baranggay);
                        $('#editCity').val(data.city);
                        $('#editProvince').val(data.province);
                        $('#userImg').attr('src', data.profilePicturePath);

                        // Show the edit profile container
                        $('.edit-profile-container').show();
                    },
                    error: function () {
                        alert('Error loading user details.');
                    }
                });
            }
        }
    });
});
