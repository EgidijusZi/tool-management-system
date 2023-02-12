import React from 'react';
import { apiService } from './../../services/business/api';
import { useState, useEffect } from 'react';
import {
  actions as initialActions,
  setActionHandlers,
} from '../../components/table/Actions';
import { BasicTable } from '../../components/table/BasicTable';
import BasicForm from '../../components/form/BasicForm';
import { Box, Button } from '@mui/material';
import { useContext } from 'react';
import { AuthContext } from '../../hooks/AuthContext';

const TablePage = ({ columns, apiBasePath }) => {
  const tablePageApiService = apiService(apiBasePath);

  const [rows, setRows] = useState([]);
  const [open, setOpen] = useState(false);
  const [selectedRow, setSelectedRow] = useState({});

  const { user } = useContext(AuthContext);

  const columnsToRemove = ['Actions', 'Used By', 'Actions With Tool'];

  const filteredColumns = columns.filter(
    (column) => !columnsToRemove.includes(column.label)
  );

  const fetchData = async () => {
    const response = await tablePageApiService.fetchAll(user.token);
    setRows(response.data);
  };

  useEffect(() => {
    fetchData();
  }, [apiBasePath]);

  const handleDelete = async (row) => {
    await tablePageApiService.delete(row.id, user.token);
    fetchData();
  };

  const handleOpen = (row) => {
    setSelectedRow(row);
    setOpen(true);
  };

  const handleClose = () => {
    setSelectedRow({});
    setOpen(false);
  };

  const handleEdit = (row) => {
    handleOpen(row);
  };

  const handleRequest = async (formInputs) => {
    if (selectedRow.hasOwnProperty('id')) {
      await tablePageApiService.put(selectedRow.id, formInputs, user.token);
    } else {
      await tablePageApiService.post(formInputs, user.token);
    }
    fetchData();
    handleClose();
  };

  const actions = setActionHandlers(initialActions, [handleEdit, handleDelete]);

  return (
    <>
      <Box>
        <Button onClick={handleOpen} variant='contained' sx={{ m: 1 }}>
          Add new
        </Button>
        <BasicForm
          columns={filteredColumns}
          onRequest={handleRequest}
          open={open}
          onDialogClose={handleClose}
          selectedRow={selectedRow}
        />
        <BasicTable columns={columns} rows={rows} actions={actions} />
      </Box>
    </>
  );
};

export default TablePage;
