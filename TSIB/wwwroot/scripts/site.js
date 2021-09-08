function showCommentModal(comment) {
    $("#txtComment").val(comment);
    $('#commentModal').modal('show');
}

function hideCommentModal(comment) {
    $('#commentModal').modal('hide');
}