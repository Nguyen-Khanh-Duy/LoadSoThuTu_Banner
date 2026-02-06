

    let deleteBannerId = null;

    function previewImage(input) {
            if (input.files && input.files[0]) {
                const reader = new FileReader();
    reader.onload = function(e) {
        document.getElementById('imagePreview').innerHTML = `
                        <img src="${e.target.result}"
                             style="max-width: 100%; max-height: 150px; border-radius: 5px;"
                             class="img-thumbnail"
                             alt="Preview">
                        <div class="mt-1">
                            <button type="button" class="btn btn-sm btn-outline-danger"
                                    onclick="document.getElementById('hinhAnhFile').value=''; document.getElementById('imagePreview').innerHTML='';">
                                <i class="fas fa-trash"></i> Xóa ảnh
                            </button>
                        </div>`;
                };
    reader.readAsDataURL(input.files[0]);
            }
        }

    function removeCurrentImage() {
        document.getElementById('currentImage').value = '';
    document.getElementById('imagePreview').innerHTML = '';
        }

    function openImageModal(imageUrl, title) {
        document.getElementById('modalImage').src = imageUrl;
    document.getElementById('imageModalTitle').textContent = title;
    new bootstrap.Modal(document.getElementById('imageModal')).show();
        }
    /* ================== EDIT BANNER ================== */
    async function editBanner(id) {
            try {
        showLoading();

    const response = await fetch(`/banner/api/get-banner/${id}`);
    if (!response.ok) throw new Error('Không thể tải dữ liệu');

    const {success, data, message} = await response.json();
    if (!success || !data) throw new Error(message || 'Lỗi dữ liệu');

    // Cập nhật giá trị form
    document.getElementById('bannerId').value = data.id;
    document.getElementById('tieuDe').value = data.tieuDe;

    // Cập nhật radio button dựa trên giá trị vị trí
    const viTri = data.viTri;
    if (viTri === 'left') {
        document.getElementById('viTriLeft').checked = true;
                } else if (viTri === 'right') {
        document.getElementById('viTriRight').checked = true;
                }

    document.getElementById('thuTu').value = data.thuTu;
    document.getElementById('noiDung').value = data.noiDung || '';
    document.getElementById('duongDan').value = data.duongDan || '';
    document.getElementById('hoatDong').checked = data.hoatDong;
    document.getElementById('idChiNhanh').value = data.idChiNhanh || '';

    // Xử lý ảnh (giữ nguyên)
    if (data.hinhAnh) {
        document.getElementById('currentImage').value = data.hinhAnh;
    document.getElementById('imagePreview').innerHTML = `
    <div class="text-center">
        <img src="${data.hinhAnh}"
            class="img-thumbnail d-block mx-auto mb-2"
            style="max-height:150px">
            <button type="button"
                class="btn btn-sm btn-outline-danger btn-delete-img d-inline-block"
                onclick="removeCurrentImage(this)">
                <i class="fas fa-trash me-1"></i> Xóa ảnh
            </button>
    </div>
    `;

    const chooseImageDiv = document.querySelector('.choose-image-section');
    if (chooseImageDiv) {
        chooseImageDiv.style.display = 'none';
                    }
                } else {
        document.getElementById('imagePreview').innerHTML = '';
    document.getElementById('currentImage').value = '';

    const chooseImageDiv = document.querySelector('.choose-image-section');
    if (chooseImageDiv) {
        chooseImageDiv.style.display = 'block';
                    }
                }

    // Cập nhật giao diện cho chế độ Edit
    updateUIForEditMode();

    // Cập nhật tiêu đề form
    updateFormTitle('SỬA BANNER');

    // Cuộn lên đầu form
    window.scrollTo({top: 0, behavior: 'smooth' });

    showToast('success', 'Đã tải dữ liệu banner');

            } catch (error) {
        showToast('error', error.message);
            } finally {
        hideLoading();
            }
        }
    function showLoading() {
        let loading = document.getElementById('loadingOverlay');
    if (!loading) {
        loading = document.createElement('div');
    loading.id = 'loadingOverlay';
    loading.style.cssText = `
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0,0,0,0.4);
    z-index: 9999;
    display: flex;
    align-items: center;
    justify-content: center;
    `;
    loading.innerHTML = `
    <div class="spinner-border text-primary" style="width:3rem;height:3rem"></div>
    `;
    document.body.appendChild(loading);
                    }
    loading.style.display = 'flex';
                }

    function hideLoading() {
                    const loading = document.getElementById('loadingOverlay');
    if (loading) loading.style.display = 'none';
                }
    /* ================== UPDATE UI FOR EDIT MODE ================== */
    function updateUIForEditMode() {
        // Cập nhật trạng thái isEditMode
        document.getElementById('isEditMode').value = 'true';

    // Hiển thị nút Hủy nếu chưa có
    const cancelButton = document.getElementById('cancelButton');
    if (!cancelButton) {
                const buttonContainer = document.querySelector('.d-grid.gap-2.mt-4');
    if (buttonContainer) {
                    const cancelBtn = document.createElement('button');
    cancelBtn.id = 'cancelButton';
    cancelBtn.type = 'button';
    cancelBtn.className = 'btn btn-secondary mb-2';
    cancelBtn.innerHTML = '<i class="fas fa-times me-1"></i> Hủy';
    cancelBtn.onclick = cancelEdit;

    // Chèn nút Hủy trước nút Lưu
    const saveButton = document.getElementById('saveButton');
    buttonContainer.insertBefore(cancelBtn, saveButton);
                }
            }

    // Cập nhật text của nút Lưu
    const saveButtonText = document.getElementById('saveButtonText');
    if (saveButtonText) {
        saveButtonText.textContent = 'CẬP NHẬT';
            }
        }

    /* ================== CANCEL EDIT ================== */
    function cancelEdit() {
            if (confirm('Bạn có chắc chắn muốn hủy chỉnh sửa? Các thay đổi chưa lưu sẽ bị mất.')) {
        // Reset form về trạng thái tạo mới
        resetFormToCreateMode();

    // Chuyển hướng về trang index không có editId
    window.location.href = '/banner/index';
            }
        }

    /* ================== RESET FORM TO CREATE MODE ================== */
    function resetFormToCreateMode() {
        // Reset các giá trị form
        document.getElementById('bannerId').value = '0';
    document.getElementById('tieuDe').value = '';

    // Reset radio button - chọn Trái làm mặc định
    document.getElementById('viTriLeft').checked = true;

    document.getElementById('thuTu').value = '0';
    document.getElementById('noiDung').value = '';
    document.getElementById('duongDan').value = '';
    document.getElementById('hoatDong').checked = true;
    document.getElementById('idChiNhanh').value = '';
    document.getElementById('currentImage').value = '';
    document.getElementById('imagePreview').innerHTML = '';

    // Reset file input
    const fileInput = document.getElementById('hinhAnhFile');
    if (fileInput) {
        fileInput.value = '';
            }

    // Hiển thị phần chọn ảnh
    const chooseImageDiv = document.querySelector('.choose-image-section');
    if (chooseImageDiv) {
        chooseImageDiv.style.display = 'block';
            }

    // Cập nhật trạng thái isEditMode
    document.getElementById('isEditMode').value = 'false';

    // Xóa nút Hủy
    const cancelButton = document.getElementById('cancelButton');
    if (cancelButton) {
        cancelButton.remove();
            }

    // Cập nhật text của nút Lưu
    const saveButtonText = document.getElementById('saveButtonText');
    if (saveButtonText) {
        saveButtonText.textContent = 'LƯU BANNER';
            }

    // Cập nhật tiêu đề form
    updateFormTitle('THÊM BANNER MỚI');
        }

    /* ================== UPDATE FORM TITLE ================== */
    function updateFormTitle(title) {
            const formTitle = document.querySelector('.card-header h5');
    if (formTitle) {
        formTitle.textContent = title;
            }
        }

    /* ================== REMOVE CURRENT IMAGE ================== */
    function removeCurrentImage(button) {
            const imagePreview = document.getElementById('imagePreview');
    const currentImage = document.getElementById('currentImage');

    // Xóa preview
    imagePreview.innerHTML = '';

    // Xóa đường dẫn ảnh hiện tại
    currentImage.value = '';

    // Reset file input
    const fileInput = document.getElementById('hinhAnhFile');
    if (fileInput) {
        fileInput.value = '';
            }

    // Hiển thị lại phần chọn ảnh
    const chooseImageDiv = document.querySelector('.choose-image-section');
    if (chooseImageDiv) {
        chooseImageDiv.style.display = 'block';
            }

    showToast('info', 'Đã xóa ảnh hiện tại. Vui lòng chọn ảnh mới nếu cần.');
        }

    /* ================== PREVIEW IMAGE ================== */
    function previewImage(input) {
            const imagePreview = document.getElementById('imagePreview');
    const currentImage = document.getElementById('currentImage');

    if (input.files && input.files[0]) {
                const reader = new FileReader();

    reader.onload = function(e) {
        imagePreview.innerHTML = `
                        <div class="text-center">
                            <img src="${e.target.result}"
                                 class="img-thumbnail d-block mx-auto mb-2"
                                 style="max-height:150px">
                            <button type="button"
                                    class="btn btn-sm btn-outline-danger btn-delete-img d-inline-block"
                                    onclick="removeCurrentImage(this)">
                                <i class="fas fa-trash me-1"></i> Xóa ảnh
                            </button>
                        </div>
                    `;

    // Ẩn phần chọn ảnh
    const chooseImageDiv = document.querySelector('.choose-image-section');
    if (chooseImageDiv) {
        chooseImageDiv.style.display = 'none';
                    }
                }

    reader.readAsDataURL(input.files[0]);
            }
        }
    /* ================== DELETE ================== */
    function confirmDelete(id, title) {
        deleteBannerId = id;
    document.getElementById('deleteMessage').textContent =
    `Bạn có chắc muốn xóa banner "${title}"?`;

    const modalEl = document.getElementById('deleteModal');
    const modal = new bootstrap.Modal(modalEl);
    modal.show();
                }

    async function deleteBanner() {
                    if (!deleteBannerId) return;

    try {
                        const response = await fetch(`/banner/delete/${deleteBannerId}`, {
        method: 'POST'
                        });

    if (!response.ok) throw new Error();

    showToast('success', 'Xóa banner thành công!');

    // Đóng modal trước
    const modalEl = document.getElementById('deleteModal');
    const modal = bootstrap.Modal.getInstance(modalEl);
    if (modal) modal.hide();

                        // Reload trang sau 0.8s cho user thấy toast
                        setTimeout(() => {
        window.location.reload();
                        }, 800);

                    } catch (error) {
        console.error(error);
    showToast('error', 'Xóa banner thất bại!');
                    } finally {
        deleteBannerId = null;
                    }
                }
    /* ================== TOGGLE STATUS ================== */
    async function toggleStatus(id, status) {
                    try {
                        const response = await fetch(`/banner/togglestatus/${id}`, {
        method: 'POST',
    headers: {'Content-Type': 'application/json' },
    body: JSON.stringify({hoatDong: !status })
                        });

    if (!response.ok) throw new Error();
    showToast('success', 'Cập nhật trạng thái thành công');

                        setTimeout(() => location.reload(), 800);

                    } catch {
        showToast('error', 'Không thể cập nhật trạng thái');
                    }
                }

    /* ================== SAVE BANNER ================== */
    async function saveBanner(e) {
        e.preventDefault();

    const isEditMode = document.getElementById('isEditMode').value === 'true';
    const bannerId = document.getElementById('bannerId').value;
    const tieuDe = document.getElementById('tieuDe').value.trim();

    // Sửa cách lấy giá trị vị trí từ radio button
    const viTriRadio = document.querySelector('input[name="viTri"]:checked');
    const viTri = viTriRadio ? viTriRadio.value : ''; // Thay thế document.getElementById('viTri').value

    const thuTu = parseInt(document.getElementById('thuTu').value) || 0;
    const noiDung = document.getElementById('noiDung').value || '';
    const duongDan = document.getElementById('duongDan').value || '';
    const hoatDong = document.getElementById('hoatDong').checked;
    const idChiNhanh = document.getElementById('idChiNhanh').value || null;
    const hinhAnhFile = document.getElementById('hinhAnhFile').files[0];
    const currentImage = document.getElementById('currentImage').value;

    // Validate
    if (!tieuDe) {
        showToast('error', 'Vui lòng nhập tiêu đề');
    return document.getElementById('tieuDe').focus();
            }

    if (!viTri) {
        showToast('error', 'Vui lòng chọn vị trí');
    return;
            }

    const formData = new FormData();
    formData.append('ID', bannerId);
    formData.append('TieuDe', tieuDe);
    formData.append('ViTri', viTri);
    formData.append('ThuTu', thuTu);
    formData.append('NoiDung', noiDung);
    formData.append('DuongDan', duongDan);
    formData.append('HoatDong', hoatDong);
    formData.append('IDChiNhanh', idChiNhanh);

    // Xử lý ảnh (giữ nguyên)
    const hasCurrentImage = currentImage && currentImage.trim() !== '';
    const hasImagePreview = document.getElementById('imagePreview').innerHTML.trim() !== '';

    if (isEditMode && !hasCurrentImage && !hasImagePreview) {
        formData.append('RemoveImage', true);
            } else if (isEditMode && hasCurrentImage && !hasImagePreview) {
        formData.append('RemoveImage', true);
            } else {
        formData.append('RemoveImage', false);
            }

    if (hinhAnhFile) {
        formData.append('HinhAnhFile', hinhAnhFile);
            }

    const url = isEditMode ? `/banner/edit/${bannerId}` : '/banner/create';

    try {
        showLoading();

    const response = await fetch(url, {
        method: 'POST',
    body: formData
                });

    if (!response.ok) {
                    const errorText = await response.text();
    throw new Error(errorText);
                }

    const result = await response.json();

    if (result.success) {
        showToast('success', isEditMode ? 'Cập nhật thành công!' : 'Thêm mới thành công!');

                    setTimeout(() => {
        window.location.href = '/banner/index';
                    }, 1200);
                } else {
                    throw new Error(result.message || 'Có lỗi xảy ra');
                }

            } catch (error) {
        console.error('Lỗi:', error);
    showToast('error', 'Lỗi: ' + error.message);
            } finally {
        hideLoading();
            }
        }
    //----------------------------- Biến lưu trạng thái lọc hiện tại---------------------------///
    let currentFilters = {
        branch: 'all',
    branchText: 'Chi nhánh',
    position: 'all',
    positionText: 'Vị trí',
    status: 'all',
    statusText: 'Trạng thái',
    searchText: ''
        };

    function applyFilters() {
            const rows = document.querySelectorAll('#bannerTable tr');
    let visibleCount = 0;

            rows.forEach(row => {
        let show = true;

    if (currentFilters.branch !== 'all') {
                    const rowBranchId = row.getAttribute('data-branch-id') || 'general';
    console.log('Row branch:', rowBranchId, 'Filter branch:', currentFilters.branch);

    if (currentFilters.branch === 'general') {

        show = show && (rowBranchId === 'general' || rowBranchId === '' || rowBranchId === '0');
                    } else {

        show = show && (rowBranchId === currentFilters.branch.toString());
                    }
                }

    if (currentFilters.position !== 'all') {
                    const rowPosition = row.getAttribute('data-position') || '';
    console.log('Row position:', rowPosition, 'Filter position:', currentFilters.position);
    show = show && (rowPosition === currentFilters.position);
                }

    if (currentFilters.status !== 'all') {
                    const rowStatus = row.getAttribute('data-status') || '';
    console.log('Row status:', rowStatus, 'Filter status:', currentFilters.status);
    show = show && (rowStatus === currentFilters.status);
                }

    if (currentFilters.searchText.trim() !== '') {
                    const searchTerm = currentFilters.searchText.toLowerCase().trim();
    const rowTitle = row.getAttribute('data-title') || '';
    const rowContent = row.getAttribute('data-content') || '';
    const rowBranchName = row.getAttribute('data-branch-name') || '';

    show = show && (
    rowTitle.includes(searchTerm) ||
    rowContent.includes(searchTerm) ||
    rowBranchName.toLowerCase().includes(searchTerm)
    );
                }

    if (show) {
        row.style.display = '';
    visibleCount++;
                } else {
        row.style.display = 'none';
                }
            });

    updateVisibleCount(visibleCount, rows.length);
        }

    function filterByBranch(branchId, branchText) {
        currentFilters.branch = branchId;
    currentFilters.branchText = branchText;

    const branchBtn = document.getElementById('branchFilterBtn');
    document.getElementById('branchFilterText').textContent = branchText;
    branchBtn.classList.add('active-filter');

    applyFilters();
        }

    function filterByPosition(position, positionText) {
        currentFilters.position = position;
    currentFilters.positionText = positionText;

    const positionBtn = document.getElementById('positionFilterBtn');
    document.getElementById('positionFilterText').textContent = positionText;
    positionBtn.classList.add('active-filter');

    applyFilters();
        }
    //------------------------------------Edit-----------------------------------------///

    //------------------------------------------------------------------------------------///
    function filterByStatus(status, statusText) {
        currentFilters.status = status;
    currentFilters.statusText = statusText;

    const statusBtn = document.getElementById('statusFilterBtn');
    document.getElementById('statusFilterText').textContent = statusText;
    statusBtn.classList.add('active-filter');

    applyFilters();
        }

    function searchBanners() {
            const searchInput = document.getElementById('searchInput');
    currentFilters.searchText = searchInput.value.toLowerCase();
    applyFilters();
        }

    function resetAllFilters() {
        currentFilters = {
            branch: 'all',
            branchText: 'Chi nhánh',
            position: 'all',
            positionText: 'Vị trí',
            status: 'all',
            statusText: 'Trạng thái',
            searchText: ''
        };

    document.getElementById('searchInput').value = '';
    document.getElementById('branchFilterText').textContent = 'Chi nhánh';
    document.getElementById('positionFilterText').textContent = 'Vị trí';
    document.getElementById('statusFilterText').textContent = 'Trạng thái';

    const filterButtons = document.querySelectorAll('.btn-outline-secondary');
            filterButtons.forEach(btn => {
        btn.classList.remove('active-filter');
            });

    const rows = document.querySelectorAll('#bannerTable tr');
            rows.forEach(row => {
        row.style.display = '';
            });

    updateVisibleCount(rows.length, rows.length);
        }

    function updateVisibleCount(visible, total) {
                const bannerHeader = document.getElementById('bannerHeader');
    if (bannerHeader) {
                    const hasActiveFilter =
    currentFilters.branch !== 'all' ||
    currentFilters.position !== 'all' ||
    currentFilters.status !== 'all' ||
    currentFilters.searchText.trim() !== '';

    if (hasActiveFilter) {
        bannerHeader.innerHTML = `
                            <i class="fas fa-list me-2"></i>DANH SÁCH BANNER (${visible}/${total})
                        `;
                    } else {

        bannerHeader.innerHTML = `
                            <i class="fas fa-list me-2"></i>DANH SÁCH BANNER (${total})
                        `;
                    }
                }

                if (visible === 0 && total > 0) {
        showNoResultsMessage();
                } else {
        hideNoResultsMessage();
                }
            }
    function showNoResultsMessage() {
        let message = document.getElementById('noResultsMessage');
    if (!message) {
        message = document.createElement('div');
    message.id = 'noResultsMessage';
    message.className = 'alert alert-info mt-3 text-center';
    message.innerHTML = `
    <i class="fas fa-info-circle me-2"></i>
    Không tìm thấy banner nào phù hợp với bộ lọc hiện tại.
    <button class="btn btn-sm btn-outline-info ms-2" onclick="resetAllFilters()">
        Hiển thị tất cả
    </button>
    `;

    const table = document.querySelector('.table-responsive');
    if (table) {
        table.parentNode.insertBefore(message, table.nextSibling);
                }
            }
    message.style.display = 'block';
        }

    function hideNoResultsMessage() {
            const message = document.getElementById('noResultsMessage');
    if (message) {
        message.style.display = 'none';
            }
        }

    document.addEventListener('DOMContentLoaded', function() {
            const searchInput = document.getElementById('searchInput');
    if (searchInput) {
        searchInput.addEventListener('keypress', function (e) {
            if (e.key === 'Enter') {
                searchBanners();
            }
        });
            }

    // Khởi tạo tooltip cho các nút
    const tooltips = document.querySelectorAll('[title]');
            tooltips.forEach(el => {
        new bootstrap.Tooltip(el);
            });
        });

    // Thêm sự kiện Enter cho ô tìm kiếm
    document.addEventListener('DOMContentLoaded', function() {
            const searchInput = document.getElementById('searchInput');
    if (searchInput) {
        searchInput.addEventListener('keypress', function (e) {
            if (e.key === 'Enter') {
                searchBanners();
            }
        });
            }

    // Khởi tạo tooltip cho các nút
    const tooltips = document.querySelectorAll('[title]');
            tooltips.forEach(el => {
        new bootstrap.Tooltip(el);
            });
        });
    // Tìm kiếm banner
    document.getElementById('searchInput').addEventListener('keyup', function(e) {
            const searchTerm = e.target.value.toLowerCase();
    const rows = document.querySelectorAll('#bannerTable tr');

            rows.forEach(row => {
                const text = row.textContent.toLowerCase();
    row.style.display = text.includes(searchTerm) ? '' : 'none';
            });
        });

    // Cập nhật số lượng banner
    function updateBannerCount() {
            const visibleRows = document.querySelectorAll('#bannerTable tr[style=""]').length;
    const totalRows = document.querySelectorAll('#bannerTable tr').length;
        }

    // Xuất Excel
    function exportBanners() {
        window.open('@Url.Action("Export", "Banner")', '_blank');
        }

    // Hiển thị toast
    function showToast(type, message) {
            if (type === 'success') {
        document.getElementById('successMessage').textContent = message;
    const toast = new bootstrap.Toast(document.getElementById('successToast'));
    toast.show();
            } else {
        document.getElementById('errorMessage').textContent = message;
    const toast = new bootstrap.Toast(document.getElementById('errorToast'));
    toast.show();
            }
        }

    // Gán sự kiện cho nút xác nhận xóa
    document.getElementById('confirmDeleteBtn').addEventListener('click', deleteBanner);

    // Tự động focus vào ô tìm kiếm khi nhấn Ctrl+F
    document.addEventListener('keydown', function(e) {
            if (e.ctrlKey && e.key === 'f') {
        e.preventDefault();
    document.getElementById('searchInput').focus();
            }
        });

    // Khởi tạo khi trang load
    document.addEventListener('DOMContentLoaded', function() {
            // Tự động focus vào ô tiêu đề nếu form trống
            if (!document.getElementById('bannerId').value || document.getElementById('bannerId').value === '0') {
        document.getElementById('tieuDe').focus();
            }

    // Thêm tooltip cho các nút
    const tooltips = document.querySelectorAll('[title]');
            tooltips.forEach(el => {
        new bootstrap.Tooltip(el);
            });
        });
