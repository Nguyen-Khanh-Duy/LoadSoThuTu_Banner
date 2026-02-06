let currentInterval = null;
const FILTER_STATE = {
    selectedKhoaId: null,
    selectedPhongId: null,
    bannerOption: 'both',
    isLoading: false
};

//=========================== CẤU HÌNH =======================//
const CONFIG = {
    refreshInterval: 30 * 1000,
    rowsToDisplay: 10,
    bannerInterval: 6000,
    dateFormatOptions: {
        weekday: 'long',
        year: 'numeric',
        month: 'long',
        day: 'numeric',
        hour: '2-digit',
        minute: '2-digit',
        second: '2-digit',
        hour12: false
    }
};

// ======================== LỚP SEARCHABLE DROPDOWN ==========================//
class SearchableDropdown {
    constructor(config) {
        this.searchInput = document.getElementById(config.searchInputId);
        this.toggleBtn = document.getElementById(config.toggleBtnId);
        this.dropdown = document.getElementById(config.dropdownId);
        this.filterInput = document.getElementById(config.filterInputId);
        this.optionsContainer = document.getElementById(config.optionsContainerId);
        this.selectElement = document.getElementById(config.selectElementId);
        this.placeholder = config.placeholder || '-- Chọn --';
        this.options = [];
        this.selectedOption = null;
        this.onSelectCallback = config.onSelect || null;

        this.init();
    }

    init() {
        this.setupEventListeners();
        this.loadOptions();
    }

    setupEventListeners() {
   
        if (this.toggleBtn) {
            this.toggleBtn.addEventListener('click', () => this.toggleDropdown());
        }

        if (this.searchInput) {
            this.searchInput.addEventListener('click', (e) => {
                e.stopPropagation();
                this.showDropdown();
            });

            this.searchInput.addEventListener('focus', () => {
                this.showDropdown();
            });
        }

        if (this.filterInput) {
            this.filterInput.addEventListener('input', (e) => {
                this.filterOptions(e.target.value);
            });
        }

        document.addEventListener('click', (e) => {
            if (!this.dropdown.contains(e.target) && !this.searchInput.contains(e.target) && !this.toggleBtn.contains(e.target)) {
                this.hideDropdown();
            }
        });

        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape' && this.dropdown.style.display === 'block') {
                this.hideDropdown();
            }
        });
    }

    async loadOptions() {
      
        if (this.selectElement.id === 'selectKhoa') {
            await this.loadKhoaOptions();
        }
    }

    async loadKhoaOptions() {
        try {
            const res = await fetch(`/load_so_thu_tu_phong/api/khoa?idChiNhanh=${_idcn}`);
            const data = await res.json();

            this.options = data;
            this.selectElement.innerHTML = '<option value="">' + this.placeholder + '</option>';

            data.forEach(k => {
                const option = document.createElement('option');
                option.value = k.id;
                option.textContent = k.ten;
                this.selectElement.appendChild(option);
            });

            this.renderOptions();
        } catch (error) {
            console.error('Error loading khoa:', error);
        }
    }

    renderOptions() {
        if (!this.optionsContainer) return;

        this.optionsContainer.innerHTML = '';

        this.options.forEach(option => {
            const optionElement = document.createElement('div');
            optionElement.className = 'dropdown-option';
            optionElement.dataset.value = option.id;
            optionElement.textContent = option.ten;

            optionElement.addEventListener('click', () => {
                this.selectOption(option.id, option.ten);
            });

            this.optionsContainer.appendChild(optionElement);
        });
    }

    filterOptions(searchText) {
        const filtered = this.options.filter(option =>
            option.ten.toLowerCase().includes(searchText.toLowerCase())
        );

        this.optionsContainer.innerHTML = '';

        filtered.forEach(option => {
            const optionElement = document.createElement('div');
            optionElement.className = 'dropdown-option';
            optionElement.dataset.value = option.id;
            optionElement.textContent = option.ten;

            optionElement.addEventListener('click', () => {
                this.selectOption(option.id, option.ten);
            });

            this.optionsContainer.appendChild(optionElement);
        });
    }

    selectOption(value, text) {
      
        if (this.searchInput) {
            this.searchInput.value = text;
        }

        if (this.selectElement) {
            this.selectElement.value = value;
       
            const event = new Event('change', { bubbles: true });
            this.selectElement.dispatchEvent(event);
        }

        this.selectedOption = { id: value, text: text };
        this.hideDropdown();

        if (this.onSelectCallback) {
            this.onSelectCallback(value, text);
        }

        if (this.selectElement.id === 'selectKhoa') {
            this.loadPhongForKhoa(value);
        }
    }

    async loadPhongForKhoa(khoaId) {
        try {
            const phongDropdown = window.phongDropdown;
            if (!phongDropdown) return;

            phongDropdown.searchInput.disabled = false;
            phongDropdown.searchInput.placeholder = 'Tìm kiếm phòng...';

            const res = await fetch(
                `/load_so_thu_tu_phong/api/phong?idChiNhanh=${_idcn}&idKhoa=${khoaId}`
            );
            const data = await res.json();

            phongDropdown.options = data;
            phongDropdown.selectElement.innerHTML = '<option value="">-- Chọn phòng --</option>';

            data.forEach(p => {
                const option = document.createElement('option');
                option.value = p.id;
                option.textContent = p.ten;
                phongDropdown.selectElement.appendChild(option);
            });

            phongDropdown.renderOptions();
            phongDropdown.searchInput.value = '';
        } catch (error) {
            console.error('Error loading phong:', error);
        }
    }

    showDropdown() {
        if (this.dropdown) {
            this.dropdown.style.display = 'block';
            if (this.filterInput) {
                this.filterInput.value = '';
                this.filterInput.focus();
            }
            this.toggleBtn.classList.add('active');
        }
    }

    hideDropdown() {
        if (this.dropdown) {
            this.dropdown.style.display = 'none';
            this.toggleBtn.classList.remove('active');
        }
    }

    toggleDropdown() {
        if (this.dropdown.style.display === 'block') {
            this.hideDropdown();
        } else {
            this.showDropdown();
        }
    }

    getValue() {
        return this.selectedOption ? this.selectedOption.id : null;
    }

    getText() {
        return this.selectedOption ? this.selectedOption.text : '';
    }

    setValue(value, text) {
        if (this.searchInput) {
            this.searchInput.value = text || '';
        }
        if (this.selectElement) {
            this.selectElement.value = value || '';
        }
        this.selectedOption = value ? { id: value, text: text } : null;
    }
}

// ======================== NÚT FULLSCREEN ==========================//

document.addEventListener("DOMContentLoaded", () => {
    downloadLogo();
    const btnFullscreen = document.getElementById("btnFullscreen");

    if (btnFullscreen) {
        function updateFullscreenIcon() {
            if (document.fullscreenElement) {
                btnFullscreen.textContent = "🗗";
                btnFullscreen.title = "Thu nhỏ";
            } else {
                btnFullscreen.textContent = "⛶";
                btnFullscreen.title = "Phóng to";
            }
        }

        document.addEventListener('fullscreenchange', updateFullscreenIcon);

        btnFullscreen.addEventListener("click", () => {
            if (!document.fullscreenElement) {
                document.documentElement.requestFullscreen().catch(err => {
                    alert(`Không thể bật full màn hình: ${err.message}`);
                });
            } else {
                document.exitFullscreen();
            }
        });

        updateFullscreenIcon();
    }
});

/**
 * Cập nhật thời gian hiện tại
 */
function updateCurrentTime() {
    const now = new Date();
    const formatter = new Intl.DateTimeFormat('vi-VN', CONFIG.dateFormatOptions);
    const formattedTime = formatter.format(now);

    const timeElement = document.getElementById('currentTime');
    if (timeElement) {
        timeElement.textContent = formattedTime;
    }
}

/**
 * Hiển thị thông báo lỗi
 */
function showError(message) {
    console.error(message);
}

/**
 * Validate dữ liệu API
 */
function validateApiData(apiData) {
    if (!apiData) {
        showError("API data is null or undefined");
        return false;
    }

    if (!Array.isArray(apiData)) {
        showError(`API data is not an array: ${typeof apiData}`);
        return false;
    }

    return true;
}

// ======================== CHUYỂN ĐỔI DỮLIỆU ==========================//

/**
 * Chuyển đổi dữ liệu từ API sang định dạng frontend
 */
function convertDataFromController(apiData) {
    if (!Array.isArray(apiData))
        return [];

    const mapped = apiData.map((x, i) => {
        let trangThai = 2;
        let trangThaiText = "Chờ";

        if (x.trangThai === 2) {
            trangThai = 1;
            trangThaiText = "Đang mời";
        }
        else if (x.trangThai === 3) {
            trangThai = 2;
            trangThaiText = "Chuẩn bị";
        }
        else if (x.trangThai === 1) {
            trangThai = 4;
            trangThaiText = "Quá lượt";
        }

        return {
            id: i + 1,
            soThuTu: String(x.soThuTu).padStart(3, '0'),
            tenBenhNhan: x.tenBenhNhan || "Không tên",
            trangThai: trangThai,
            trangThaiText: trangThaiText
        };
    });

    mapped.sort((a, b) => {
        if (a.trangThai !== b.trangThai)
            return a.trangThai - b.trangThai;

        return parseInt(a.soThuTu) - parseInt(b.soThuTu);
    });

    return mapped;
}

// ================================= RENDER FUNCTIONS ===============================//

/**
 * Render danh sách bệnh nhân
 */
function renderPatientRows(data, soDongHienThi = CONFIG.rowsToDisplay) {
    const tbody = document.getElementById("sttList");
    if (!tbody) {
        showError("Element #sttList not found!");
        return;
    }

    console.log(`Rendering ${data.length} items`);

    tbody.innerHTML = "";

    if (!data || data.length === 0) {
        const tr = document.createElement("tr");
        tr.innerHTML = `
            <td colspan="3" class="text-center py-5" style="font-size: 2.5rem; color: #338BB9;">
                Không có dữ liệu bệnh nhân
            </td>
        `;
        tbody.appendChild(tr);
        return;
    }

    let mainData = data
        .filter(item => item.trangThai !== 4)
        .sort((a, b) => {
            const priority = (t) => {
                if (t === 1) return 0;
                if (t === 2) return 1;
                return 2;
            };

            const diff = priority(a.trangThai) - priority(b.trangThai);

            if (diff !== 0)
                return diff;

            return parseInt(a.soThuTu) - parseInt(b.soThuTu);
        })
        .slice(0, soDongHienThi);

    console.log("Main data to render:", mainData);

    mainData.forEach((item, index) => {
        const tr = document.createElement("tr");

        let statusClass = "status-wait";
        let statusText = item.tenBenhNhan || "Không tên";

        if (index % 2 === 0) {
            tr.style.backgroundColor = "#f8fbff";
        }

        const isInviting = item.trangThai === 1;

        tr.innerHTML = `
            <td class="${statusClass}" 
                style="font-size:70px;padding:19px 15px;line-height:1;
                ${isInviting ? 'animation: blinkRed 1s infinite; color: red;' : ''}">
                ${item.tenBenhNhan}
            </td>

            <td style="font-size:80px;font-weight:bold;padding:19px 15px;line-height:1;
                ${isInviting ? 'animation: blinkRed 1s infinite; color: red;' : ''}">
                ${item.soThuTu}
            </td>

            <td style="font-size:70px;font-weight:bold;padding:19px 15px;line-height:1;
                ${isInviting ? 'animation: blinkRed 1s infinite; color: red;' : 'color:#338BB9;'}">
                ${item.trangThaiText}
            </td>
            `;

        tbody.appendChild(tr);
    });

    if (mainData.some(item => item.trangThai === 1)) {
        const style = document.createElement('style');
        style.textContent = `
            @keyframes blinkRed {
                0% { opacity: 1; color: red; }
                50% { opacity: 0.5; color: #ff6666; }
                100% { opacity: 1; color: red; }
            }
        `;
        document.head.appendChild(style);
    }
}

/**
 * Render danh sách qua lượt
 */
function renderQuaLuotTicker(data) {
    const quaLuotContainer = document.getElementById("quaLuotList");
    if (!quaLuotContainer) {
        showError("Element #quaLuotList not found!");
        return;
    }

    quaLuotContainer.innerHTML = "";

    const quaLuotPatients = data.filter(item => item.trangThai === 4);
    if (quaLuotPatients.length === 0) {
        const emptyPill = document.createElement("div");
        emptyPill.className = "ticker-item";
        emptyPill.innerText = "Không có bệnh nhân qua lượt";
        emptyPill.style.opacity = "0.7";

        quaLuotContainer.appendChild(emptyPill);
    } else {
        quaLuotPatients.forEach((patient, index) => {
            const pill = document.createElement("div");
            pill.className = "ticker-item";

            const separator = (index < quaLuotPatients.length - 1)
                ? "  |  "
                : "";

            pill.innerHTML = `
            <strong>${patient.soThuTu}</strong> - ${patient.tenBenhNhan}${separator}
        `;

            pill.style.color = "white";

            quaLuotContainer.appendChild(pill);
        });
    }

    setTimeout(() => {
        quaLuotContainer.classList.add("loaded");

        const content = quaLuotContainer.querySelector('.ticker-content');
        if (content) {
            content.style.animation = 'none';
            setTimeout(() => {
                content.style.animation = 'scroll-left 120s linear infinite';
            }, 10);
        }
    }, 100);
}

// ============================ BANNER FUNCTIONS ======================//

/**
 * Lấy banner từ API
 */
async function fetchBanners() {
    try {
        const response = await fetch('/banner/api/get-active-banners');
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const banners = await response.json();
        return banners || [];
    } catch (error) {
        console.error("Error fetching banners:", error);
        return [];
    }
}

/**
 * Lấy logo từ FTP
 */
async function downloadLogo() {
    try {
        const ftpPath = 'LogoDHYD/OIP.jpg';
        const response = await fetch(`/banner/ftp/download?path=${encodeURIComponent(ftpPath)}`);

        if (!response.ok) {
            throw new Error('Failed to download file');
        }

        const blob = await response.blob();
        const imageUrl = URL.createObjectURL(blob);

        const imgElement = document.querySelector('.header-logo');
        imgElement.src = imageUrl;
        console.log("anh ne:", imageUrl);
        return imageUrl;
    } catch (error) {
        console.error('Error downloading logo:', error);
        return null;
    }
}

/**
 * Khởi tạo banner slider động
 */
async function initDynamicBannerSlider(elementId, position, interval = CONFIG.bannerInterval) {
    const el = document.getElementById(elementId);
    if (!el) {
        console.warn(`Element #${elementId} not found for banner`);
        return;
    }

    try {
        const banners = await fetchBanners();
        const filteredBanners = banners.filter(b => b.viTri === position && b.hoatDong);

        if (filteredBanners.length === 0) {
            el.innerHTML = `
                <div class="banner-content">
                    <img src="/dist/img/default-banner.jpg" alt="Banner mặc định">
                    <div class="banner-text">Quảng cáo</div>
                </div>
            `;
            return;
        }

        let currentIndex = 0;

        function renderBanner() {
            const banner = filteredBanners[currentIndex];
            const bannerContent = `
                <div class="banner-content">
                    ${banner.duongDan ?
                    `<a href="${banner.duongDan}" target="_blank">` : ''}
                    <img src="${banner.hinhAnh}" alt="${banner.tieuDe}" 
                         onerror="this.src='/dist/img/default-banner.jpg'">
                
                </div>
            `;

            el.style.opacity = '0';
            setTimeout(() => {
                el.innerHTML = bannerContent;
                el.style.opacity = '1';
            }, 300);

            currentIndex = (currentIndex + 1) % filteredBanners.length;
        }

        renderBanner();

        if (filteredBanners.length > 1) {
            setInterval(renderBanner, interval);
        }

    } catch (error) {
        console.error(`Error initializing banner ${position}:`, error);
        el.innerHTML = `
            <div class="banner-content">
                <img src="/dist/img/default-banner.jpg" alt="Banner lỗi">
                <div class="banner-text">Đang tải banner...</div>
            </div>
        `;
    }
}

// ============================== DATA FETCHING ==========================//
/**
 * Lấy dữ liệu từ API với filter
 */
async function fetchDataFromControllerWithFilter(khoaId = null, phongId = null) {
    try {
        const requestData = {};

        if (khoaId) requestData.IdKhoa = khoaId;
        if (phongId) requestData.IdPhongBuong = phongId;
        if (_idcn) requestData.IdChiNhanh = _idcn;

        const response = await fetch('/load_so_thu_tu_phong/api/lcd-data', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(requestData)
        });

        const json = await response.json();

        if (!json.success) {
            console.error("API error:", json);
            return [];
        }

        return json.data || [];
    } catch (error) {
        console.error("Error fetching filtered data:", error);
        return [];
    }
}

/**
 * Main function để load dữ liệu với filter
 */
async function loadSTT(useFilter = false) {
    try {
        console.log("=== loadSTT() started at", new Date().toLocaleTimeString(), "===");

        let apiData;

        if (useFilter && (FILTER_STATE.selectedKhoaId || FILTER_STATE.selectedPhongId)) {
            apiData = await fetchDataFromControllerWithFilter(
                FILTER_STATE.selectedKhoaId,
                FILTER_STATE.selectedPhongId
            );
            console.log("Using filtered data:", {
                khoa: FILTER_STATE.selectedKhoaId,
                phong: FILTER_STATE.selectedPhongId
            });
        } else {
            apiData = await fetchDataFromController();
        }

        const convertedData = convertDataFromController(apiData);

        console.log("Data ready for rendering:", convertedData.length, "items");

        renderPatientRows(convertedData);
        renderQuaLuotTicker(convertedData);

        console.log("=== Rendering completed ===");

        if (currentInterval) clearTimeout(currentInterval);
        currentInterval = setTimeout(() => loadSTT(useFilter), CONFIG.refreshInterval);

    } catch (err) {
        console.error("Error in loadSTT():", err);

        const tbody = document.getElementById("sttList");
        if (tbody) {
            tbody.innerHTML = `
                <tr>
                    <td colspan="3" class="text-center py-5" style="font-size: 2.5rem; color: red;">
                        Lỗi kết nối. Thử lại sau...
                    </td>
                </tr>
            `;
        }

        if (currentInterval) clearTimeout(currentInterval);
        currentInterval = setTimeout(() => loadSTT(useFilter), 10000);
    }
}

// =============================== INITIALIZATION ================================//

/**
 * Khởi tạo ứng dụng
 */
async function initializeApp() {
    console.log("Initializing application...");

    const requiredElements = ['sttList', 'quaLuotList', 'bannerLeft', 'bannerRight', 'hospitalTitle'];
    const missingElements = requiredElements.filter(id => !document.getElementById(id));

    if (missingElements.length > 0) {
        console.warn("Missing elements:", missingElements);
    }

    updateCurrentTime();
    setInterval(updateCurrentTime, 1000);

    window.khoaDropdown = new SearchableDropdown({
        searchInputId: 'searchKhoa',
        toggleBtnId: 'toggleKhoa',
        dropdownId: 'dropdownKhoa',
        filterInputId: 'filterKhoa',
        optionsContainerId: 'khoaOptions',
        selectElementId: 'selectKhoa',
        placeholder: '-- Chọn khoa --'
    });

    window.phongDropdown = new SearchableDropdown({
        searchInputId: 'searchPhong',
        toggleBtnId: 'togglePhong',
        dropdownId: 'dropdownPhong',
        filterInputId: 'filterPhong',
        optionsContainerId: 'phongOptions',
        selectElementId: 'selectPhong',
        placeholder: '-- Chọn phòng --'
    });

    await Promise.all([
        initDynamicBannerSlider('bannerLeft', 'left'),
        initDynamicBannerSlider('bannerRight', 'right'),
    ]);

    const hasSavedSettings = restoreFilterSettings();

    if (!hasSavedSettings) {
        restoreHospitalTitle();
    }

    await loadSTT(hasSavedSettings);

    console.log("Application initialized successfully");
}

/**
 * Dọn dẹp khi page unload
 */
function cleanup() {
    if (currentInterval) {
        clearTimeout(currentInterval);
        currentInterval = null;
    }
    console.log("Application cleaned up");
}

// ================================ EVENT LISTENERS ===========================//

if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initializeApp);
} else {
    initializeApp();
}

window.addEventListener('beforeunload', cleanup);
window.addEventListener('unload', cleanup);

document.addEventListener('keydown', function (e) {
    if (e.key === 'F5') {
        e.preventDefault();
        loadSTT();
        console.log("Manual refresh triggered");
    }

    if (e.ctrlKey && e.key === 'r') {
        e.preventDefault();
        loadSTT();
        console.log("Manual refresh triggered");
    }
});

window.addEventListener('online', () => {
    console.log("Network connection restored");
    loadSTT();
});

window.addEventListener('offline', () => {
    console.log("Network connection lost");
    showError("Mất kết nối mạng. Đang thử kết nối lại...");
});

//======================================================================//

document.addEventListener('DOMContentLoaded', function () {
    const leftBanner = document.getElementById('bannerLeft');
    const rightBanner = document.getElementById('bannerRight');
    const contentCenter = document.querySelector('.content-center');
    const radios = document.querySelectorAll('input[name="bannerOption"]');

    let bannerOption = localStorage.getItem('bannerOption') || 'both';

    document.querySelector(`input[value="${bannerOption}"]`).checked = true;

    applyBannerOption(bannerOption);

    radios.forEach(radio => {
        radio.addEventListener('change', function () {
            bannerOption = this.value;
            localStorage.setItem('bannerOption', bannerOption);
            applyBannerOption(bannerOption);
        });
    });

    function applyBannerOption(option) {
        if (leftBanner) leftBanner.style.display = 'none';
        if (rightBanner) rightBanner.style.display = 'none';

        switch (option) {
            case 'both':
                if (leftBanner) leftBanner.style.display = 'flex';
                if (rightBanner) rightBanner.style.display = 'flex';
                contentCenter.style.width = '72%';
                break;

            case 'left':
                if (leftBanner) leftBanner.style.display = 'flex';
                contentCenter.style.width = '85%';
                break;

            case 'right':
                if (rightBanner) rightBanner.style.display = 'flex';
                contentCenter.style.width = '85%';
                break;

            case 'none':
                contentCenter.style.width = '100%';
                break;
        }
    }
});

//============================= Lưu  ======================//
/**
 * Xử lý lưu cài đặt filter
 */
async function handleSaveSettings() {
    try {
        const saveBtn = document.getElementById('saveRoomBtn');
        if (!saveBtn) return;

        saveBtn.disabled = true;
        const originalText = saveBtn.innerHTML;
        saveBtn.innerHTML = `
            <span class="spinner-border spinner-border-sm me-2"></span>
            Đang lưu...
        `;

        const khoaId = window.khoaDropdown ? window.khoaDropdown.getValue() : null;
        const khoaText = window.khoaDropdown ? window.khoaDropdown.getText() : '';
        const phongId = window.phongDropdown ? window.phongDropdown.getValue() : null;
        const phongText = window.phongDropdown ? window.phongDropdown.getText() : '';

        const bannerRadio = document.querySelector('input[name="bannerOption"]:checked');

        FILTER_STATE.selectedKhoaId = khoaId;
        FILTER_STATE.selectedPhongId = phongId;
        FILTER_STATE.bannerOption = bannerRadio ? bannerRadio.value : 'both';

        localStorage.setItem('filterSettings', JSON.stringify({
            khoaId: FILTER_STATE.selectedKhoaId,
            phongId: FILTER_STATE.selectedPhongId,
            bannerOption: FILTER_STATE.bannerOption,
            khoaName: khoaText,
            phongName: phongText,
            lastUpdated: new Date().toISOString()
        }));

        updateHospitalTitle(
            FILTER_STATE.selectedKhoaId,
            FILTER_STATE.selectedPhongId,
            khoaText,
            phongText
        );

        applyBannerOption(FILTER_STATE.bannerOption);

        await loadSTT(true);

        showToast('Cài đặt đã được lưu thành công!', 'success');

        const modalElement = document.getElementById('settingsModal');
        if (modalElement) {
            const modal = bootstrap.Modal.getInstance(modalElement);
            if (modal) modal.hide();
        }

    } catch (error) {
        console.error('Error saving settings:', error);
        showToast('Có lỗi xảy ra khi lưu cài đặt!', 'error');
    } finally {
        const saveBtn = document.getElementById('saveRoomBtn');
        if (saveBtn) {
            saveBtn.disabled = false;
            saveBtn.innerHTML = 'Lưu';
        }
    }
}

/**
 * Hiển thị toast thông báo
 */
function showToast(message, type = 'info') {
    let toastContainer = document.getElementById('toastContainer');
    if (!toastContainer) {
        toastContainer = document.createElement('div');
        toastContainer.id = 'toastContainer';
        toastContainer.className = 'position-fixed top-0 end-0 p-3';
        toastContainer.style.zIndex = '1060';
        document.body.appendChild(toastContainer);
    }

    const toastId = 'toast-' + Date.now();
    const toastHtml = `
        <div id="${toastId}" class="toast align-items-center text-bg-${type} border-0" role="alert">
            <div class="d-flex">
                <div class="toast-body">
                    ${message}
                </div>
                <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast"></button>
            </div>
        </div>
    `;

    toastContainer.insertAdjacentHTML('beforeend', toastHtml);

    const toastElement = document.getElementById(toastId);
    const toast = new bootstrap.Toast(toastElement, {
        autohide: true,
        delay: 3000
    });
    toast.show();

    toastElement.addEventListener('hidden.bs.toast', function () {
        toastElement.remove();
    });
}

/**
 * Khôi phục cài đặt từ localStorage
 */
function restoreFilterSettings() {
    try {
        const savedSettings = localStorage.getItem('filterSettings');
        if (savedSettings) {
            const settings = JSON.parse(savedSettings);

            FILTER_STATE.selectedKhoaId = settings.khoaId;
            FILTER_STATE.selectedPhongId = settings.phongId;
            FILTER_STATE.bannerOption = settings.bannerOption || 'both';

            if (window.khoaDropdown && settings.khoaId) {
                window.khoaDropdown.setValue(settings.khoaId, settings.khoaName);
            }

            if (window.phongDropdown && settings.phongId) {
                window.phongDropdown.setValue(settings.phongId, settings.phongName);
            }

            const bannerRadios = document.querySelectorAll('input[name="bannerOption"]');
            if (bannerRadios.length > 0) {
                bannerRadios.forEach(radio => {
                    radio.checked = (radio.value === FILTER_STATE.bannerOption);
                });
            }

            if (settings.khoaName || settings.phongName) {
                updateHospitalTitle(
                    settings.khoaId,
                    settings.phongId,
                    settings.khoaName,
                    settings.phongName
                );
            }

            applyBannerOption(FILTER_STATE.bannerOption);

            return true;
        }
    } catch (error) {
        console.error('Error restoring settings:', error);
    }
    return false;
}

/**
 * Cập nhật tiêu đề hiển thị theo khoa và phòng đã chọn
 */
function updateHospitalTitle(khoaId = null, phongId = null, khoaName = '', phongName = '') {
    const titleElement = document.getElementById('hospitalTitle');
    if (!titleElement) return;

    if (!khoaId && !phongId) {
        const defaultTitle = '';
        titleElement.innerHTML = defaultTitle || '';
        return;
    }

    let newTitle = '';

    if (khoaName) {
        newTitle += `<span class="khoa-name" style="color: white;">${khoaName}</span>`;
    }

    if (phongName) {
        if (khoaName) newTitle += ' - ';
        newTitle += `<span class="phong-name" style="color: yellow; font-weight: bold;">Phòng ${phongName}</span>`;
    }

    if (!khoaName && !phongName) {
        newTitle = `<span style="color: white;">Đang tải...</span>`;
    }

    titleElement.innerHTML = newTitle;

    localStorage.setItem('hospitalTitle', newTitle);
    localStorage.setItem('selectedKhoaName', khoaName);
    localStorage.setItem('selectedPhongName', phongName);
}

/**
 * Khôi phục tiêu đề từ localStorage
 */
function restoreHospitalTitle() {
    try {
        const savedTitle = localStorage.getItem('hospitalTitle');
        const khoaName = localStorage.getItem('selectedKhoaName');
        const phongName = localStorage.getItem('selectedPhongName');

        const titleElement = document.getElementById('hospitalTitle');
        if (!titleElement) return;

        if (savedTitle && (khoaName || phongName)) {
            titleElement.innerHTML = savedTitle;
            return true;
        }
    } catch (error) {
        console.error('Error restoring hospital title:', error);
    }
    return false;
}

// ============================= EVENT LISTENERS FOR FILTER =====================//

document.addEventListener('DOMContentLoaded', function () {
    const saveBtn = document.getElementById('saveRoomBtn');
    if (saveBtn) {
        saveBtn.addEventListener('click', handleSaveSettings);
    }

    const settingsModal = document.getElementById('settingsModal');
    if (settingsModal) {
        settingsModal.addEventListener('keydown', function (e) {
            if (e.key === 'Enter' && !e.target.matches('input[type="radio"]')) {
                e.preventDefault();
                handleSaveSettings();
            }
        });
    }

    settingsModal.addEventListener('hidden.bs.modal', function () {
        const saveBtn = document.getElementById('saveRoomBtn');
        if (saveBtn) {
            saveBtn.disabled = false;
            saveBtn.innerHTML = 'Lưu';
        }
    });
});

/**
 * Áp dụng tùy chọn hiển thị banner
 */
function applyBannerOption(option) {
    const leftBanner = document.getElementById('bannerLeft');
    const rightBanner = document.getElementById('bannerRight');
    const contentCenter = document.querySelector('.content-center');

    if (!contentCenter) return;

    if (leftBanner) leftBanner.style.display = 'none';
    if (rightBanner) rightBanner.style.display = 'none';

    switch (option) {
        case 'both':
            if (leftBanner) leftBanner.style.display = 'flex';
            if (rightBanner) rightBanner.style.display = 'flex';
            contentCenter.style.width = '72%';
            break;

        case 'left':
            if (leftBanner) leftBanner.style.display = 'flex';
            contentCenter.style.width = '85%';
            break;

        case 'right':
            if (rightBanner) rightBanner.style.display = 'flex';
            contentCenter.style.width = '85%';
            break;

        case 'none':
            contentCenter.style.width = '100%';
            break;
    }
}

function addClearFilterButton() {
    const titleContainer = document.getElementById('hospitalTitle');
    if (!titleContainer) return;

    if (document.getElementById('clearFilterBtn')) return;

    const clearBtn = document.createElement('button');
    clearBtn.id = 'clearFilterBtn';
    clearBtn.className = 'btn btn-sm btn-outline-light ms-3';
    clearBtn.innerHTML = '✕';
    clearBtn.title = 'Xóa bộ lọc';
    clearBtn.style.cssText = `
        width: 30px;
        height: 30px;
        border-radius: 50%;
        padding: 0;
        font-size: 16px;
        line-height: 1;
    `;

    clearBtn.addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        if (confirm('Bạn có chắc muốn xóa bộ lọc hiện tại?')) {
            clearAllFilters();
        }
    });

    const hasFilter = FILTER_STATE.selectedKhoaId || FILTER_STATE.selectedPhongId;
    clearBtn.style.display = hasFilter ? 'inline-block' : 'none';

    titleContainer.parentNode.style.position = 'relative';
    titleContainer.appendChild(clearBtn);
}

/**
 * Xóa tất cả filter
 */
function clearAllFilters() {
    FILTER_STATE.selectedKhoaId = null;
    FILTER_STATE.selectedPhongId = null;

    // Reset dropdowns
    if (window.khoaDropdown) {
        window.khoaDropdown.setValue(null, '');
    }
    if (window.phongDropdown) {
        window.phongDropdown.setValue(null, '');
        window.phongDropdown.searchInput.disabled = true;
        window.phongDropdown.searchInput.placeholder = 'Chọn khoa trước';
    }

    const defaultTitle = '';
    const titleElement = document.getElementById('hospitalTitle');
    if (titleElement) {
        titleElement.innerHTML = defaultTitle || '';
    }

    localStorage.removeItem('filterSettings');
    localStorage.removeItem('hospitalTitle');
    localStorage.removeItem('selectedKhoaName');
    localStorage.removeItem('selectedPhongName');

    const clearBtn = document.getElementById('clearFilterBtn');
    if (clearBtn) clearBtn.style.display = 'none';

    loadSTT(false);
    showToast('Đã xóa bộ lọc!', 'info');
}

window.LoadSoThuTuApp = {
    loadSTT,
    initializeApp,
    cleanup,
    handleSaveSettings,
    restoreFilterSettings,
    FILTER_STATE,
    CONFIG
};