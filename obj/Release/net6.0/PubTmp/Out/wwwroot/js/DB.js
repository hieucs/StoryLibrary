var databaseName = 'story';
var tableName = 'View';
var version = 1;

var db;

function openDatabase() {
    var request = indexedDB.open(databaseName, version);

    request.onerror = function (event) {
        console.log('Error opening database:', event.target.error);
    };

    request.onsuccess = function (event) {
        db = event.target.result;
        console.log('Database opened successfully:', db);
    };

    request.onupgradeneeded = function (event) {
        var db = event.target.result;
        var objectStore = db.createObjectStore(tableName, { keyPath: 'id', autoIncrement: true });
        objectStore.createIndex('name', 'name', { unique: false });
        console.log('Database upgraded successfully:', db);
    };
}

function addDataToTable(data) {
    var transaction = db.transaction([tableName], 'readwrite');
    var objectStore = transaction.objectStore(tableName);
    var request = objectStore.add(data);

    request.onerror = function (event) {
        console.log('Error adding data:', event.target.error);
    };

    request.onsuccess = function (event) {
        console.log('Data added successfully:', event.target.result);
    };
}

openDatabase();
