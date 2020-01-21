function Delete(url) {
    if (confirm('Are you sure to delete this record?') === true) {
        $.ajax({
            type: 'POST',
            url: url,
            success: function (response) {
                console.log(response);
                if (response.success) {
                    alert('Success');
                }
                else {
                    alert('error');
                }
            }
        });  
    }   
}

