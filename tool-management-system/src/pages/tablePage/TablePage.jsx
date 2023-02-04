import React from 'react';
import { apiService } from './../../services/business/api';
import { useState, useEffect } from 'react';
import {
  actions as initialActions,
  setActionHandlers,
} from '../../components/table/Actions';
import { BasicTable } from '../../components/table/BasicTable';
import CreationForm from '../../components/form/CreationForm';
import { Box, Button } from '@mui/material';

const TablePage = ({ columns, apiBasePath }) => {
  const tablePageApiService = apiService(apiBasePath);

  const [rows, setRows] = useState([]);
  const [open, setOpen] = useState(false);

  const fetchData = async () => {
    const response = await tablePageApiService.fetchAll();
    setRows(response.data);
  };

  useEffect(() => {
    fetchData();
  }, [apiBasePath]);

  const handleDelete = async (row) => {
    await tablePageApiService.delete(row.id);
    fetchData();
  };

  const handleOpen = () => {
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const handleEdit = async () => {
    return;
  };

  const handleCreate = async () => {
    return;
  }

  const actions = setActionHandlers(initialActions, [handleEdit, handleDelete]);

  return (
    <>
      <Box>
      <Button onClick={handleOpen} variant='contained' sx={{ m: 1 }}>
        Add new
      </Button>
        <CreationForm
          columns={columns.filter((column) => column.label !== 'Actions')}
          onCreate={handleCreate}
          open={open}
          onDialogClose={handleClose}
        />
        <BasicTable columns={columns} rows={rows} actions={actions} />
      </Box>
    </>
  );
};

export default TablePage;
